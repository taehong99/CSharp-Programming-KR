namespace _07._Class
{
    internal class Program
    {
        /***********************************************************************
         * Ŭ���� (class)
         * 
         * �����Ϳ� ���� ����� ĸ��ȭ�� �� �ִ� ���� ����
         * ��ü���� ���α׷��ֿ� ��ü�� ����� ���� ���赵
         * Ŭ������ ��ü�� ����� ���� ���赵�̸�, ������� ��ü�� �ν��Ͻ��� ��
         * ���� : ������ ����Ű�� ���� == ������ �ּҸ� ������ ����
         ***********************************************************************/

        // <Ŭ���� ����>
        // class Ŭ�����̸� { Ŭ�������� }
        // Ŭ���� �������δ� ������ �Լ��� ���� ����
        class Student
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

        void Main1()
        {
            Student kim = null;     // ���������� �����ϰ� null(�ƹ��͵� ����) ����
            kim = new Student();    // Ŭ���� �ν��Ͻ��� �����ϰ� ���������� �ν��Ͻ��� ������
            kim.name = "Kim";       // �ν��Ͻ��� ������ �����ϱ� ���� ������ ������ . �� �ٿ� ���
            kim.math = 10;
            kim.english = 20;
            kim.science = 100;

            float average = kim.GetAverage();   // Ŭ������ �Լ��� �����ϱ� ���� ������ ������ . �� �ٿ� ���
        }


        // <Ŭ���� ������>
        // ��ȯ���� ���� Ŭ�����̸��� �Լ��� �����ڶ� �ϸ� Ŭ������ �ν��Ͻ��� ���� �� ȣ��Ǵ� ���ҷ� ���
        // �ν��Ͻ��� �����ڴ� new Ű���带 ���ؼ� ���
        class Car
        {
            public string name;
            public string color;

            // �⺻�����ڴ� �ٸ� �����ڸ� �������� ���� ��쿡�� �ڵ� ������
            /*public Car()
            {

            }*/

            public Car(string name, string color)
            {
                this.name = name;
                this.color = color;
            }
        }

        void Main2()
        {
            Car car;
            // car.name = "��";         // error : Ŭ���� ���������� �ν��Ͻ� ���� ���Ұ�

            Car truck = new Car("Ʈ��", "�Ķ���");
            Console.WriteLine($"{truck.name}, {truck.color}");    // output : Ʈ��, �Ķ���

            // Car taxi = new Car();    // error : �⺻�����ڴ� �ٸ������ڸ� �������� ���� ��쿡�� �ڵ�������
        }


        // <Ŭ���� ��������>
        // Ŭ������ ���Կ�����(=)�� ���� ���� �ν��Ͻ��� ������
        class MyClass
        {
            public int value1;
            public int value2;
        }

        void Main3()
        {
            MyClass s = new MyClass();
            s.value1 = 1;
            s.value2 = 2;

            MyClass t = s;      // ������ ���� �ν��Ͻ��� ������
            t.value1 = 3;

            // ���� �ν��Ͻ��� �����ϱ� ������ ���纻�� �����ϴ� ��� ������ �����
            Console.WriteLine(s.value1);    // 3
            Console.WriteLine(s.value2);    // 2

            Console.WriteLine(t.value1);    // 3
            Console.WriteLine(t.value2);    // 2
        }



        /*******************************************
         * ������, ��������
         * 
         * ������ (Value type) : 
         * ������ �� �������� ����� (���� ����)
         * ����ü�� ������
         * 
         * �������� (Reference type) : 
         * ������ �� ��ü�ּҰ� ����� (���� ����)
         * Ŭ������ ��������
         ********************************************/

        // <�����İ� ���������� ����>
        // ������ : �����Ͱ� �߿��� ��� ���, ���� �����
        // �������� : ��ü�� �߿��� ��� ���, ��ü�ּҰ� �����
        struct ValueType
        {
            public int value;
        }

        class RefType
        {
            public int value;
        }

        void Main4()
        {
            ValueType valueType1 = new ValueType() { value = 10 };
            ValueType valueType2 = valueType1;      // ���� ����
            valueType2.value = 20;                  // ���� �����ص� �������� ���� ����
            Console.WriteLine(valueType1.value);    // output : 10

            RefType refType1 = new RefType() { value = 10 };
            RefType refType2 = refType1;            // ��ü�ּҰ� ����
            refType2.value = 20;                    // ���� �����ϴ� ��� ���� �����͸� ����
            Console.WriteLine(refType1.value);      // output : 20
        }


        // <���� ���� ȣ��, ������ ���� ȣ��>
        // ���� ���� ȣ�� (Call by value) : 
        // �������� �����Ͱ� ���޵Ǹ� �����Ͱ� ����Ǿ� ���޵�
        // �Լ��� �Ű������� �����ϴ� ��� ������ ���� ���޵Ǹ� ������ ������
        void Swap(ValueType left, ValueType right)
        {
            int temp = left.value;
            left.value = right.value;
            right.value = temp;
        }

        // ������ ���� ȣ�� (Call by reference) :
        // ���������� �����Ͱ� ���޵Ǹ� �ּҰ� ����Ǿ� ���޵�
        // �Լ��� �Ű������� �����ϴ� ��� �ּҰ� ���޵Ǹ� �ּҸ� ���� �����ϱ� ������ ������ �����ϴ� ȿ��
        void Swap(RefType left, RefType right)
        {
            int temp = left.value;
            left.value = right.value;
            right.value = temp;
        }

        void Main5()
        {
            ValueType leftValue = new ValueType() { value = 10 };
            ValueType rightValue = new ValueType() { value = 20 };
            Swap(leftValue, rightValue);    // �������� ���纻�� �Լ��� ���� ������ ������ �ٲ��� ����
            Console.WriteLine($"{leftValue.value}, {rightValue.value}");    // output : 10, 20

            RefType leftRef = new RefType() { value = 10 };
            RefType rightRef = new RefType() { value = 20 };
            Swap(leftRef, rightRef);        // ������ �ּҰ� �Լ��� ���� ������ ������ �ٲ�
            Console.WriteLine($"{leftRef.value}, {rightRef.value}");        // output : 20, 10
        }


        // <��������, ��������>
        // �������� (Shallow copy) : ��ü�� ������ �� �ּҰ����� �����Ͽ� ���� ������ ����Ű�� ��
        // �������� (Deep copy) : ��ü�� ������ �� �ּҰ� ���� ������ �����Ͽ� �ٸ� ��ü�� ������ ����Ű�� ��
        void Main6()
        {
            RefType original = new RefType() { value = 1 };

            // ��������
            RefType shallowCopy = original;

            // ��������
            RefType deepCopy = new RefType();
            deepCopy.value = original.value;

            Console.WriteLine(original.value);      // output : 1
            Console.WriteLine(shallowCopy.value);   // output : 1
            Console.WriteLine(deepCopy.value);      // output : 1

            original.value = 2;

            Console.WriteLine(original.value);      // output : 2
            Console.WriteLine(shallowCopy.value);   // output : 2
            Console.WriteLine(deepCopy.value);      // output : 1
        }


        static void Main(string[] args)
        {

        }
    }
}