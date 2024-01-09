namespace _13._Exception
{
    internal class Program
    {
        /****************************************************************
         * ����ó�� (Exception Handling)
         *
         * ���α׷� ���� ���� �߻��ϴ� �ǵ����� ���� ��Ȳ�� ó���ϴ� ���
         ****************************************************************/

        // <���ǹ��� ���� ����ó��>
        // ���α׷��� �ߴܵ� �� �������� ó���� ���ǹ��� ���� ������ �� ������ ����
        // ���� ���� ����ó�� ����� ó������ ���ܰ� �߻��� �� ������ �����ϴ� ��
        void Main1()
        {
            int value1 = 10;
            int value2 = 0;

            // ���� value2�� 0�� ��� ����ó���� �������� ������ ���α׷��� �ߴܵ�
            // �Ʒ��� ���ǹ��� ���� ���α׷��� �ߴܵǴ� ��Ȳ�� ���� ����ó���� ����
            if (value2 != 0)
            {
                double result = value1 / (double)value2;
                Console.WriteLine($"����� {result}");
            }
            else
            {
                Console.WriteLine("0 ���� ���� �� �����ϴ�.");
            }
        }


        // <try catch ����ó��>
        // ���ܰ� �߻��� �� �ִ� ������ �����ϰ� ������ ���ܰ� �߻��� ��� �߻��� ���ܸ� ó���ϴ� ������ �ۼ�
        // try : ���ܹ߻��� ���� �˻��� ������ �����ϴ� ���
        // catch : �߻��� ���ܸ� ó���ϴ� ���
        void Main2()
        {
            try
            {
                // try ���� ������ ó���� �� ���� ���ܻ�Ȳ �߻���
                // catch ������ ó���� �� �ִ� ����ó�� �κ��� �����

                Console.Write("���� �Է��ϼ��� : ");
                string input = Console.ReadLine();

                int value = int.Parse(input);
                int[] array = new int[value];

                array[10] = 10;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("�Է°��� ������ ��ȯ�� �Ұ��� ��� ���� �߻�");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("�Է°����� �迭�� ���� �� ���� ��� ���� �߻�");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("�Է°��� 10 ������ ��� [10] �ε��� ������ �Ұ��Ͽ� ���� �߻�");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("��� ���� ��Ȳ�� Ȯ���ϰ� ���� �߻��� ó��");
            }
        }


        // <throw ���� �߻�>
        // �ǵ������� ���ܸ� �߻���Ű�� ���
        // ���α׷����� ġ������ �� �ִ� ������ ����Ǵ� ��� ���� ó���� �����ϱ� ���� ����
        void Main3()
        {
            try
            {
                int[] array = { 1, 3, 5, 7, 9 };
                int index = Array.IndexOf(array, 8);    // ���� ã�� �� ���� ��� -1 ��ȯ

                if (index < 0)
                    throw new InvalidOperationException();

                array[index] = 0;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("�迭���� ���ϴ� ���� ã�� ����");
            }
        }


        // <���� Ǯ��>
        // �Լ����� ���ܰ� �߻��� ��� catch ���� �߰��� ������ ȣ��� ������ Ǯ�
        void Func3() { Console.Write("3��"); throw new Exception("����Ǯ��"); Console.Write("3��"); }
        void Func2() { Console.Write("2��"); Func3(); Console.Write("2��"); }
        void Func1() { Console.Write("1��"); Func2(); Console.Write("1��"); }

        void Main4()
        {
            try
            {
                Func1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        static void Main(string[] args)
        {

        }
    }
}