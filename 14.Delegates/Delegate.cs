namespace _14._Delegate
{
    internal class Program
    {
        /****************************************************************
         * �븮�� (Delegate)
         * 
         * Ư�� �Ű� ���� ��� �� ��ȯ ������ �ִ� �Լ��� ���� ����
         * �븮�� �ν��Ͻ��� ���� �Լ��� ȣ�� �� �� ����
         ****************************************************************/

        // <��������Ʈ ����>
        // delegate ��ȯ�� ��������Ʈ�̸�(�Ű�������);
        public delegate float DelegateMethod1(float x, float y);
        public delegate void DelegateMethod2(string str);


        public float Plus(float left, float right) { return left + right; }
        public float Minus(float left, float right) { return left - right; }
        public float Multi(float left, float right) { return left * right; }
        public float Divide(float left, float right) { return left / right; }
        public void Message(string message) { Console.WriteLine(message); }


        // <��������Ʈ ���>
        // ��ȯ���� �Ű������� ��ġ�ϴ� �Լ��� ��������Ʈ ������ �Ҵ�
        // ��������Ʈ ������ ������ �Լ��� �븮�ڸ� ���� ȣ�� ����
        void Main1()
        {
            DelegateMethod1 delegate1 = new DelegateMethod1(Plus);  // ��������Ʈ �ν��Ͻ� ����
            DelegateMethod2 delegate2 = Message;                    // ������ ������ ��������Ʈ �ν��Ͻ� ����

            delegate1.Invoke(20, 10);   // Plus(20, 10);            // Invoke�� ���� �����Ǿ� �ִ� �Լ��� ȣ��
            delegate2("�޼���");        // Message("�޼���");       // ������ ������ ��������Ʈ �Լ� ȣ��

            delegate1 = Plus;
            Console.WriteLine(delegate1(20, 10));       // output : 30
            delegate1 = Minus;
            Console.WriteLine(delegate1(20, 10));       // output : 10
            delegate1 = Multi;
            Console.WriteLine(delegate1(20, 10));       // output : 200
            delegate1 = Divide;
            Console.WriteLine(delegate1(20, 10));       // output : 2

            // delegate2 = Plus;        // error : ��ȯ���� �Ű������� ��ġ���� ���� �Լ��� ���� �Ұ�
        }

        static void Main(string[] args)
        {

        }
    }
}