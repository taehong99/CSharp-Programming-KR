namespace _16._Additional
{
    internal class Program
    {
        // C#���� ���� ����� ������ �ִ� ����� ����� �ִ� ���� ����Ʈ
        // C#���� �����Ǵ� ��ɵ��� �ξ� ����ȭ�� �� �Ǿ� �ִ� ��찡 ����

        void Main()
        {
            // �⺻�ڷ����� �Լ�
            // �⺻�ڷ����� ����ü �Ǵ� Ŭ������ ������
            // �� ����ü�� Ŭ���� �ȿ� ������ ����� �����Ǿ� ����
            string str = "abc def";
            str.ToLower();                  // �ҹ��� ��ȯ
            str.ToUpper();                  // �빮�� ��ȯ
            str.Split(' ');                 // ���ڿ� ������
            str.Replace('a', 'z');          // ���� ��ü

            int[] array = { 1, 2, 3, 4, 5 };
            array.Max();                    // �ִ밪
            array.Min();                    // �ּҰ�
            array.Average();                // ��հ�


            // �⺻�ڷ����� static �Լ�
            // �⺻�ڷ����� �ν��Ͻ� ���� ��밡���� �Լ����� �����Ǿ� ����
            int.Parse("12");                // int ����ȯ
            int value = int.MaxValue;       // int �ִ밪

            String.Compare("abc", "abd");   // ���ڿ� ��

            int[] values = { 5, 2, 1, 4, 3 };
            Array.Sort(values);             // �迭 ����
            Array.Reverse(values);          // �迭 ����
        }



        static void Main(string[] args)
        {

        }
    }
}