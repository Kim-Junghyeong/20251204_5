namespace _20251204_5
{
    // 값의 참조 실습1
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 배열 생성
            int[] arr = new int[5]; // 초기화 되어 있음(ref)
            int[] arr2;             // 초기화 필요 없음(out)
            // ref 배열 채우기
            FillArray(ref arr);
            // 배열 출력
            PrintArray(arr);

            // out배열 채우기
            FillArray2(out arr2, 3);
            PrintArray2(arr2);


        }
        // ref 키워드 이용 배열 채우기 메서드
        void FillArray(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
        }
        // 배열 출력 메서드
        void PrintArray(int[] array)
        {
            Console.Write("[ref] 배열 값: ");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        void FillArray2(out int[] array, int size)
        {
            array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
        }
        void PrintArray2(int[] array)
        {
            Console.Write("[out] 배열 값: ");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
