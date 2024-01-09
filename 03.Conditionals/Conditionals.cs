namespace _03._Conditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /****************************************************************
             * ���ǹ� (Conditional)
             *
             * ���ǿ� ���� ������ �޶����� �� �� ����ϴ� ����
             ****************************************************************/



            /****************************************************************
             * if ���ǹ�
             *
             * ���ǽ��� true, false�� ���� ������ ����� �����ϴ� ���ǹ�
             ****************************************************************/

            // <if ���ǹ� �⺻>
            if (true)   // ������ true�� ��� �ٷ� �Ʒ��� ����� �����
            {
                Console.WriteLine("����Ǵ� ���");
            }
            else
            {
                Console.WriteLine("������� �ʴ� ���");
            }

            if (false)  // ������ false�� ��� else ����� �ִٸ� �����
            {
                Console.WriteLine("������� �ʴ� ���");
            }
            else
            {
                Console.WriteLine("����Ǵ� ���");
            }


            // else ����� ���û������� �ʿ���� ��� �߰����� �ʾƵ� ��
            if (true)
            {
                Console.WriteLine("����Ǵ� ���");
            }
            /* else
            {
                // �ƹ��͵� ���� ����;
            } */


            // else if ���� �߰������� ���� ������ Ȯ���� �� ����
            // else if Ű���尡 ���� �ִ� ���� �ƴ� else + if
            string input = "����";
            if (input == "����")
            {
                Console.WriteLine("������ �Է�");
            }
            else if (input == "����")
            {
                Console.WriteLine("������ �Է�");
            }
            else if (input == "��")
            {
                Console.WriteLine("���� �Է�");
            }
            else
            {
                Console.WriteLine("�߸��� ���� �Է�");
            }



            /****************************************************************
             * switch ���ǹ�
             *
             * ���ǰ��� ���� ������ ���������� �����ϴ� ���ǹ�
             ****************************************************************/

            // <switch ���ǹ� �⺻>
            string cmd = "B";
            switch (cmd)        // ���ǰ� ����
            {
                case "A":       // ���ǰ��� ��ġ���� �ʾ� �Ѿ
                    Console.WriteLine("A�� ��ġ�ϴ� ���");
                    break;
                case "B":       // ���ǰ��� ��ġ�ϴ� case���� ������
                    Console.WriteLine("B�� ��ġ�ϴ� ���");
                    break;      // break; �� �ִ� �������� switch ����� ��������
                case "C":
                    Console.WriteLine("C�� ��ġ�ϴ� ���");
                    break;
            }


            // ���ǰ��� ��ġ�ϴ� case�� ���� ��� default �� ���������� ��
            int value = 7;
            switch (value)
            {
                case 1:
                    Console.WriteLine("���� 1");
                    break;
                case 2:
                    Console.WriteLine("���� 2");
                    break;
                default:            // ���ǰ��� case�� ��ġ�� ���� ������ default�� ���������� ��
                    Console.WriteLine("���� �� ��");
                    break;
            }


            // ���ǰ��� ���� ������ ������ �ʿ��� ��� ��� ��� ����
            char key = 'w';
            switch (key)
            {
                case 'w':
                case 'W':
                case '��':
                    Console.WriteLine("�������� �̵�");
                    break;
                case 'a':
                case 'A':
                case '��':
                    Console.WriteLine("�������� �̵�");
                    break;
                case 's':
                case 'S':
                case '��':
                    Console.WriteLine("�Ʒ������� �̵�");
                    break;
                case 'd':
                case 'D':
                case '��':
                    Console.WriteLine("���������� �̵�");
                    break;
                default:
                    Console.WriteLine("�̵����� ����");
                    break;
            }



            /****************************************************************
             * ���׿�����
             *
             * ������ ���ǹ��� ������ �ۼ�
             ****************************************************************/

            // <���� ������ �⺻>
            // ���� ? true�� ��� �� : false�� ��� ��
            int big = 20 > 10 ? 20 : 10;      // ������ true�̴� 20
            int small = 20 < 10 ? 20 : 10;      // ������ false�̴� 10
        }
    }
}