namespace _05._Function
{
    internal class Program
    {
        /****************************************************************
         * �Լ� (Function)
         *
         * �̸� ������ ������ �����ϴ� �ڵ� ����
         * � ó���� �̸� �Լ��� ����� �θ� �ٽ� �ݺ������� ��� ����
         ****************************************************************/

        // <�Լ� ����>
        // �Ϸ��� �ڵ带 �ϳ��� �̸� �Ʒ��� ����
        // ��ȯ�� �Լ��̸�(�Ű��������) { �Լ����� }
        int Plus(int left, int right)
        {
            Console.WriteLine($"Input : {left}, {right}");
            int result = left + right;
            Console.WriteLine($"Output : {result}");
            return result;
        }


        // <�Լ� ���>
        // �Լ��� �����ص� �ڵ带 �̸��� �ҷ� �����
        void Main1()
        {
            // �Լ��� ������� �ʴ� ���
            Console.WriteLine($"Input : {1}, {2}");
            int result1 = 1 + 2;
            Console.WriteLine($"Output : {result1}");
            int value1 = result1;

            Console.WriteLine($"Input : {3}, {4}");
            int result2 = 3 + 4;
            Console.WriteLine($"Output : {result2}");
            int value2 = result2;

            Console.WriteLine($"Input : {5}, {6}");
            int result3 = 5 + 6;
            Console.WriteLine($"Output : {result3}");
            int value3 = result3;

            // �Լ��� ����ϴ� ���
            int value4 = Plus(1, 2);
            int value5 = Plus(3, 4);
            int value6 = Plus(5, 6);
        }


        // <��ȯ�� (Return Type)>
        // �Լ��� ���(���) �������� �ڷ���
        // �Լ��� ������ ������ �ݵ�� return���� ��ȯ���� �´� �����͸� ����ؾ���
        // �Լ� ���� �� return�� ������ ��� �� ��� ��� �����͸� ��ȯ�ϰ� �Լ��� �����
        // �Լ��� ���(���)�� ���� ��� ��ȯ���� void�̸� return�� ��������
        int Return10()
        {
            // return �� �����ϱ� ������ �ڵ尡 ���������� ����
            Console.WriteLine("�������� �ϴ� �ڵ�");

            return 10;

            // return ���� �ڵ�� ������� ����
            Console.WriteLine("�������� ���ϴ� �ڵ�");
        }

        void PrintProfile(string name, string phone)
        {
            if (name == "")
            {
                Console.WriteLine("�̸��� �Է����ּ���.");
                return;     // void ��ȯ������ return�� �����ϴ� ��� �Լ� ������ ������ ��
            }

            Console.WriteLine($"�̸� : {name}, Phone : {phone}");

            // void ��ȯ���� �Լ��� return�� ��������
        }

        void Main2()
        {
            int ret = Return10();   // Return10 �Լ����� ��ȯ�� 10�� ����� ����

            PrintProfile("", "010-1234-5678");          // void ��ȯ���� �Լ��� ���࿡ �ǹ�
            PrintProfile("ȫ�浿", "010-1111-2222");
        }


        // <�Ű����� (Parameter)>
        // �Լ��� �߰�(�Է�)�� �������� �ڷ����� ������
        // ���� �Լ������� �Ű����� �Է��� �ٸ��� ���� �ٸ� ó���� ����
        int Minus(int left, int right)
        {
            // �Լ��� �Է����� �־��� �Ű����� left, right �� ���� �Լ��� ����
            return left - right;
        }

        void Main3()
        {
            int value1 = Minus(20, 10);     // �Ű����� 20, 10�� �� Minus �Լ��� ��ȯ�� 10
            int value2 = Minus(30, 10);     // �Ű����� 30, 10�� �� Minus �Լ��� ��ȯ�� 20
        }


        // <�Լ� ȣ�� ����>
        // �Լ��� ȣ��Ǿ��� �� �ش� �Լ�������� ��� ���۵Ǹ� �Ϸ�Ǿ��� �� ����ġ�� ��� ���۵�
        int Func2()
        {   /*4*/
            /*5*/
            int ret = 1;
            /*6*/
            return ret;
        }

        int Func1()
        {   /*2*/
            /*3*/
            int ret = Func2(); /*7*/
            /*8*/
            return ret + 1;
        }

        void Main4()
        {   /*����*/
            /*1*/
            int ret = Func1(); /*9*/
        }   /*����*/


        // <�Լ� �����ε�>
        // ���� �̸��� �Լ��� �Ű������� �޸��Ͽ� �ٸ� �Լ��� �������ϴ� ���
        // ���� �̸��� �Լ��� ȣ���Ͽ��� �Ű������� �ڷ����� ���� �Լ��� �޸� ȣ���� �� ����
        int Multi(int left, int right) { return left * right; }
        float Multi(float left, float right) { return left * right; }
        double Multi(double left, double right) { return left * right; }

        void Main5()
        {
            int result1 = Multi(5, 3);     // Multi(int, int)�� ȣ���
            float result2 = Multi(5.1f, 3.3f);     // Multi(float, float)�� ȣ���
            double result3 = Multi(5.1, 3.3);     // Multi(double, double)�� ȣ���
        }


        static void Main(string[] args)
        {

        }
    }
}