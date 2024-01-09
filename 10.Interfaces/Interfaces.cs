namespace _10._Interface
{
    internal class Program
    {
        /***************************************************************************
         * �������̽� (Interface)
         * 
         * �������̽��� �ɹ��� ���� �� ������ ���� �������� ���� ���� ���Ǹ��� ����
         * �������̽��� ������ Ŭ�������� �ݵ�� �������̽��� ���Ǹ� �����ؾ���
         * �̸� �ݴ�� ǥ�����ڸ� �������̽��� �����ϴ� Ŭ������
         * �ݵ�� �������̽��� ���� ��ҵ��� �����ߴٴ� ���� ������
         * Can-a ���� : Ŭ������ �ش� �ൿ�� �� �� �ִ� ��� ������
         ***************************************************************************/

        // <�������̽� ����>
        // �Ϲ������� �������̽��� �̸��� I�� ������
        // �������̽��� �Լ��� ���� �������� �ʰ� ���Ǹ� ����
        public interface IEnterable
        {
            void Enter();
        }

        public interface IOpenable
        {
            void Open();
        }


        // <�������̽� ����>
        // ���ó�� ������ �������̽��� Ŭ���� : �ڿ� �����Ͽ� ���
        // �������̽��� �����ϴ� ��� �ݵ�� �������̽����� ������ �Լ��� �����ؾ� ��
        // �������̽��� ������ ���� ����
        public class Door : IEnterable, IOpenable
        {
            public void Enter()
            {
                Console.WriteLine("���� ���ϴ�.");
            }

            public void Open()
            {
                Console.WriteLine("���� ���ϴ�.");
            }
        }

        public class Town : IEnterable
        {
            public void Enter()
            {
                Console.WriteLine("������ ���ϴ�.");
            }
        }

        public class Box : IOpenable
        {
            public void Open()
            {
                Console.WriteLine("���ڸ� ���ϴ�.");
            }
        }


        // <�������̽� ���>
        // �������̽��� �̿��Ͽ� ����� ������ ���
        // Ŭ������ ��Ӱ���� �����ϰ� �ൿ�� ���ɿ��η� ��ȣ�ۿ� ����
        public class Player
        {
            public void Enter(IEnterable enterable)
            {
                Console.WriteLine("�÷��̾ ��� ���� �õ��մϴ�.");
                enterable.Enter();
            }

            public void Open(IOpenable openable)
            {
                Console.WriteLine("�÷��̾ ����� ���� �õ��մϴ�.");
                openable.Open();
            }
        }

        void Main()
        {
            Player player = new Player();

            Door door = new Door();
            Box box = new Box();
            Town town = new Town();

            // player.Enter(box);               // error : Box �� IEnterable �������̽��� ����
            player.Enter(door);
            player.Enter(town);

            player.Open(box);
            player.Open(door);
            // player.Open(town);               // error : Town �� IOpenable �������̽��� ����

            IEnterable enterable;
            enterable = new Door();
            enterable = new Town();
            // enterable = new IEnterable();    // error : �������̽��� �ν��Ͻ�ȭ �Ұ�
        }


        static void Main(string[] args)
        {

        }
    }
}