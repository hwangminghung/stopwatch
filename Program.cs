using System;

class StopWatch
{
    private DateTime startTime;
    private DateTime endTime;

    // Getter cho startTime
    public DateTime StartTime
    {
        get { return startTime; }
    }

    // Getter cho endTime
    public DateTime EndTime
    {
        get { return endTime; }
    }

    // Phương thức khởi tạo không tham số
    public StopWatch()
    {
        startTime = DateTime.Now;
    }

    // Phương thức Start
    public void Start()
    {
        startTime = DateTime.Now;
    }

    // Phương thức Stop
    public void Stop()
    {
        endTime = DateTime.Now;
    }

    // Phương thức GetElapsedTime
    public TimeSpan GetElapsedTime()
    {
        return endTime - startTime;
    }
}

class Program
{
    static void Main(string[] args)
    {
        StopWatch stopwatch = new StopWatch();

        // Đo thời gian thực thi của thuật toán sắp xếp chọn (selection sort)
        int[] numbers = GenerateRandomNumbers(10000);
        stopwatch.Start();
        SelectionSort(numbers);
        stopwatch.Stop();

        Console.WriteLine("Thời gian thực thi của thuật toán sắp xếp chọn (selection sort) cho 10000 số: " + stopwatch.GetElapsedTime());
    }

    // Hàm sắp xếp chọn (selection sort)
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    // Hàm sinh mảng ngẫu nhiên
    static int[] GenerateRandomNumbers(int length)
    {
        Random random = new Random();
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = random.Next(100000);
        }
        return numbers;
    }
}