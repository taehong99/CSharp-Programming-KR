namespace _06._UserDefineType
{
    internal class Program
    {
        /********************************************************************
         * ������ (Enum)
         * 
         * �⺻ ���� ������ ������ ���� ��� ���տ� ���� ���ǵǴ� �� ����
         * ������ ����� �̸����� �����Ǿ� �ڵ��� ���������� ���鿡 ������ ��
         ********************************************************************/

        // <������ �⺻���>
        // enum �������̸� { ����̸�, ����̸�, ... }
        enum Direction { Up, Down, Left, Right }    // ������ ���� : �������̸��� ����̸� �ۼ�
        void Main1()
        {
            Direction dir = Direction.Up;           // ������ ���� : �������� ���� ������ ����
            switch (dir)
            {
                case Direction.Up:                  // �����ڷ������� �ڵ� �������� ����
                    Console.WriteLine("���� �������� �̵�");
                    break;
                case Direction.Down:
                    Console.WriteLine("�Ʒ��� �������� �̵�");
                    break;
                case Direction.Left:
                    Console.WriteLine("���� �������� �̵�");
                    break;
                case Direction.Right:
                    Console.WriteLine("������ �������� �̵�");
                    break;
            }
        }


        // <������ ��ȯ>
        enum Season
        {
            Spring, // 0    // ������ ����� �������� �������� ���� ��� 0���� ����
            Summer, // 1    // ������ ����� �������� �������� ���� ��� ���� �ɹ� +1 ���� ����
            Autumn = 20,    // �������� ���� �Ҵ� ����
            Winter  // 21   // �������� ���� �Ҵ��� ��쿡�� ���� ��� +1 ���� ����
        }

        void Main2()
        {
            Season season1 = Season.Autumn;
            Console.WriteLine($"{season1}�� �������� {(int)season1} �Դϴ�.");  // ������������ int�� ����ȯ

            Season season2 = (Season)0;     // �������� ������������ ����ȯ
            Console.WriteLine(season2);     // Spring
        }



        /**************************************************
         * ����ü (Struct)
         * 
         * �����Ϳ� ���� ����� ĸ��ȭ�� �� �ִ� �� ����
         * �����͸� �����ϱ� �����ϱ� ���� �����뵵�� ���
         **************************************************/

        // <����ü ����>
        // struct ����ü�̸� { ����ü���� }
        // ����ü �������δ� ������ �Լ��� ���� ����
        struct StudentInfo
        {
            public string name;
            public int math;
            public int english;
            public int science;

            public float GetAverage()
            {
                return (math + english + science) / 3f;
            }
        }


        void Main3()
        {
            StudentInfo kim;            // ����ü ���� ����
            kim.name = "Kim";           // ����ü�� ������ �����ϱ� ���� ����ü�� .�� �ٿ� ���
            kim.math = 10;
            kim.english = 20;
            kim.science = 100;

            float average = kim.GetAverage();   // ����ü�� �Լ��� �����ϱ� ���� ����ü�� .�� �ٿ� ���
        }


        // <����ü �ʱ�ȭ>
        // ��ȯ���� ���� ����ü�̸��� �Լ��� �ʱ�ȭ�� �ϸ� ����ü �������� �ʱ�ȭ�� �����ϴ� ���ҷ� ���
        // �Ű������� �ִ� �ʱ�ȭ�� �����Ͽ� ����ü ������ ���� �����ϱ� ���� �뵵�� ���
        // ����ü�� �ʱ�ȭ�� new Ű���带 ���ؼ� ���
        struct Point
        {
            public int x;
            public int y;

            // C#  9.0 ���� ���� : �⺻ �ʱ�ȭ�� �ڵ����� �����Ǹ� ������ �� ����
            // C# 10.0 ���� ���� : �⺻ �ʱ�ȭ�� �߰����� �ʴ� ��� �ڵ����� �����Ǹ� �߰��Ͽ� ���� ����
            /*public Point()
            {
                this.x = 0;
                this.y = 0;
            }*/

            public Point(int x, int y)
            {
                // �ʱ�ȭ���� ��� ����ü ������ �ʱ�ȭ���� ������ error �߻�
                this.x = x;     // this : �ڱ� �ڽ��� ����Ŵ
                this.y = y;
            }
        }

        void Main4()
        {
            Point point1;
            point1.x = 1;
            Console.WriteLine($"{point1.x}");
            // Console.WriteLine($"{point1.y}");            // error : �ʱ�ȭ���� ���� ���� ���

            Point point2 = new Point();                     // �⺻ �ʱ�ȭ ���
            Console.WriteLine($"{point2.x}, {point2.y}");   // output : 0, 0

            Point point3 = new Point(1, 2);                 // �߰��� ������ �ʱ�ȭ ���
            Console.WriteLine($"{point3.x}, {point3.y}");   // output : 1, 2

            Point point4 = new Point() { x = 3, y = 4 };    // �ʱ�ȭ �� ������
            Console.WriteLine($"{point4.x}, {point4.y}");   // output : 3, 4
        }


        // <����ü ��������>
        // ����ü�� ���Կ�����(=)�� ���� ����ü �� ��� �������� ���� �����
        struct MyStruct
        {
            public int value1;
            public int value2;
        }

        void Main5()
        {
            MyStruct s;
            s.value1 = 1;
            s.value2 = 2;

            MyStruct t = s;     // ����ü �� ��� �������� ���� �����
            t.value1 = 3;

            Console.WriteLine(s.value1);    // 1
            Console.WriteLine(s.value2);    // 2

            Console.WriteLine(t.value1);    // 3
            Console.WriteLine(t.value2);    // 2
        }


        static void Main(string[] args)
        {

        }
    }
}