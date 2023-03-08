#pragma warning disable
public class Vector
{
    public double[] Array { get; set; }
    public Vector(double[] array) { Array = (double[])array.Clone(); }
    public Vector() : this(1) { }

    public Vector(int n)
    {
        if (n <= 0) { n = 1; }
        Array = new double[n];

    }

    public void InpVector()
    {
        for (int i = 0; i < Array.Length; i++) { Array[i] = Convert.ToDouble(Console.ReadLine()); }
    }
    public override string ToString()
    {
        string array = " ";
        for (int i = 0; i < Array.Length; i++) { array = array + Array[i] + " "; }
        return array;
    }
    public double Module()
    {
        double sum_sqrt = 0;
        for (int i = 0; i < Array.Length; i++) { sum_sqrt += Math.Pow(Array[i], 2); }
        return Math.Sqrt(sum_sqrt);
    }
    public double Maxelem()
    {
        int index = 0;
        for (int i = 0; i < Array.Length; i++) { if (Array[i] > Array[index]) index = i; } 
        return Array[index];
    }
    public int Minelemindex()
    {
        int index = 0;
        for (int i = 1; i < Array.Length; i++) { if (Array[i] < Array[index]) index = i; }    
        return index;
    }
    public Vector PosElemVector()
    {
        int size = 0, count = 0;
        for (int i = 0; i < Array.Length; i++) { if (Array[i] > 0) size++; }
        Vector new_array = new(size);
        for (int i = 0; i < Array.Length; i++) { if (Array[i] > 0) new_array.Array[count++] = Array[i]; }
        return new_array;
    }
    public static Vector? Summary(Vector x, Vector y)
    {
        if (x.Array.Length != y.Array.Length)
        {
            return null;
        }
        Vector result = new(x.Array.Length);
        for (int i = 0; i < x.Array.Length; i++) { result.Array[i] = x.Array[i] + y.Array[i]; }
        return result;
    }
    public static double? Product(Vector x, Vector y)
    {
        if (x.Array.Length != y.Array.Length)
        {
            return null;
        }
        double result = 0;
        for (int i = 0; i < x.Array.Length; i++)
        {
            result += x.Array[i] * y.Array[i];

        }
        return result;
    }
    public static bool Equality(Vector x, Vector y)
    {
        if (x.Array.Length != y.Array.Length)
            return false;
        for (int i = 0; i < x.Array.Length; i++)
        {
            if (x.Array[i] != y.Array[i])
                return false;
        }
        return true;
    }

    public double ElementReturn(int i)
    {
        if (i >= 0) return Array[i];
        else return Array[^-i];
    }

    public void ElementChange(int i, double new_element)
    {
        if (i >= 0)
            Array[i] = new_element;
        else
            Array[^-i] = new_element;
    }

    public void VectorRandom(int x, int y)
    {
        Random rand = new();
        for (int i = 0; i < Array.Length; i++) Array[i] = rand.Next(x, y);
    }

    public int LineSearch(double element)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] == element) return i;

        }
        return -1;
    }

    public bool CheckSort()
    {
        for (int i = 0; i < Array.Length - 1;)
        {
            if (Array[i] > Array[++i]) return false;
        }
        return true;
    }

    public int BinarySearch(double element)
    {
        bool flag = false;
        int middle = 0, l = 0, r = Array.Length - 1;
        while ((l <= r) & (!flag))
        {
            middle = (l + r) / 2;
            if (Array[middle] == element) flag = true;
            else if (Array[middle] > element) r = middle - 1;
            else l = middle + 1;
        }
        if (flag) return middle;
        return -1;
    }


    public void RightShiftOnePos()
    {
        int n = Array.Length;
        double[] x = new double[n];
        for (int i = 0; i < n; i++)
        {
            x[(i + 1) % n] = Array[i];
        }
        Array = x;
    }


    public bool NegativeElOnEvenPl()
    {
        for (int i = 0; i < Array.Length; i += 2)
        {
            if (Array[i] >= 0) return false;
        }
        return true;
    }

    public static void MergeSort(double[] arr, int start, int end)
    {
        if (start < end)
        {
            int mid = (start + end) / 2;        // Делим входной массив на 2
            MergeSort(arr, start, mid);        // сортируем первую часть массива
            MergeSort(arr, mid + 1, end);      // сортируем вторую часть массива

            // соединяем оба подмассива
            Merge(arr, start, mid, end);
        }
    }
    public static void Merge(double[] arr, int start, int mid, int end)
    {
        int x = start, y = mid + 1;

        double[] tempArr = new double[end - start + 1];
        int k = 0;

        for (int i = start; i <= end; i++)
        {
            if (x > mid)                     //проверка левой части
                tempArr[k++] = arr[y++];

            else if (y > end)               //проверка правой части
                tempArr[k++] = arr[x++];

            else if (arr[x] < arr[y])       //добавляем в массив меньший из двух элементов
                tempArr[k++] = arr[x++];

            else
                tempArr[k++] = arr[y++];
        }
        for (int j = 0; j < k; j++)
        {
            //исходный массив включает в себя эл-ы из двух отсортированных частей
            arr[start++] = tempArr[j];
        }
    }
}














