namespace _12._Generic
{
    internal class Program
    {
        /********************************************************************************************
         * �Ϲ�ȭ (Generic)
         * 
         * Ŭ���� �Ǵ� �Լ��� �ڵ忡 ���� ����ǰ� �ν��Ͻ�ȭ�� ������ ������ ����� �����ϴ� ������
         * ����� ������ �� �ڷ����� ��� ��ÿ� �����ؼ� ���
         ********************************************************************************************/

        // <�Ϲ�ȭ �Լ�>
        // �Ϲ�ȭ�� ���� ��� �ڷ������� �Լ��� �ۼ�
        public static void IntArrayCopy(int[] source, int[] output)
        {
            for (int i = 0; i < source.Length; i++) { output[i] = source[i]; }
        }

        public static void FloatArrayCopy(float[] source, float[] output)
        {
            for (int i = 0; i < source.Length; i++) { output[i] = source[i]; }
        }

        public static void DoubleArrayCopy(double[] source, double[] output)
        {
            for (int i = 0; i < source.Length; i++) { output[i] = source[i]; }
        }

        // �Ϲ�ȭ�� �̿��ϸ� �� �Լ���� �ٸ� �ڷ����� �Լ� ���� ȣȯ�� �� ����
        public static void ArrayCopy<T>(T[] source, T[] output)
        {
            for (int i = 0; i < source.Length; i++) { output[i] = source[i]; }
        }

        void Main1()
        {
            int[] iSrc = { 1, 2, 3, 4, 5 };
            float[] fSrc = { 1f, 2f, 3f, 4f, 5f };
            double[] dSrc = { 1d, 2d, 3d, 4d, 5d };

            int[] iDst = new int[iSrc.Length];
            float[] fDst = new float[fSrc.Length];
            double[] dDst = new double[dSrc.Length];

            // �Ϲ�ȭ�� ���� ��� �ڷ������� �Լ� ����
            IntArrayCopy(iSrc, iDst);
            FloatArrayCopy(fSrc, fDst);
            DoubleArrayCopy(dSrc, dDst);

            // �Ϲ�ȭ�� �Լ��� �ڷ����� ������ �Լ� ����
            ArrayCopy<int>(iSrc, iDst);         // �ڷ����� �Լ� ȣ�� ��� ����
            ArrayCopy<float>(fSrc, fDst);
            ArrayCopy<double>(dSrc, dDst);

            char[] cSrc = { 'a', 'b', 'c' };
            char[] cDst = new char[cSrc.Length];
            ArrayCopy(cSrc, cDst);              // �Ϲ�ȭ �ڷ����� �Ű������� ���� ���� ������ ��� ���� ����
        }


        // <�Ϲ�ȭ Ŭ����>
        // Ŭ������ �ʿ��� �ڷ����� �Ϲ�ȭ�Ͽ� ����
        // ���� Ŭ���� �ν��Ͻ��� ������ �� �ڷ����� �����Ͽ� ���
        public class SafeArray<T>
        {
            T[] array;

            public SafeArray(int size)
            {
                array = new T[size];
            }

            public void Set(int index, T value)
            {
                if (index < 0 || index >= array.Length)
                    return;

                array[index] = value;
            }

            public T Get(int index)
            {
                if (index < 0 || index >= array.Length)
                    return default(T);      // default : T �ڷ����� �⺻��

                return array[index];
            }
        }


        // <�Ϲ�ȭ �ڷ��� ����>
        // �Ϲ�ȭ �ڷ����� ������ �� ���������� �����Ͽ�, ��� ��� �� �� �ִ� �ڷ����� ����
        class StructT<T> where T : struct { }           // T�� ����ü�� ��� ����
        class ClassT<T> where T : class { }             // T�� Ŭ������ ��� ����
        class NewT<T> where T : new() { }               // T�� �Ű����� ���� �����ڰ� �ִ� �ڷ����� ��� ����

        class ParentT<T> where T : Parent { }           // T�� Parent �Ļ�Ŭ������ ��� ����
        class InterfaceT<T> where T : IComparable { }   // T�� �������̽��� ������ �ڷ����� ��� ����

        class Parent { }
        class Child : Parent { }

        void Main2()
        {
            StructT<int> structT = new StructT<int>();          // int�� ����ü�̹Ƿ� struct ���������� �ִ� �Ϲ�ȭ �ڷ����� ��� ����
            // ClassT<int> classT = new ClassT<int>();          // error : int�� ����ü�̹Ƿ� class ���������� �ִ� �Ϲ�ȭ �ڷ����� ��� �Ұ�
            NewT<int> newT = new NewT<int>();                   // int�� new int() �����ڰ� �����Ƿ� ��� ����

            ParentT<Parent> parentT = new ParentT<Parent>();    // Parent�� Parent �Ļ�Ŭ�����̹Ƿ� ��� ����
            ParentT<Child> childT = new ParentT<Child>();       // Child�� Parent �Ļ�Ŭ�����̹Ƿ� ��� ����
            InterfaceT<int> interT = new InterfaceT<int>();     // int�� IComparable �������̽��� �����ϹǷ� ��� ����
        }


        // <�Ϲ�ȭ ���� �뵵>
        // �Ϲ�ȭ �ڷ����� ���������� �ִٸ� ���԰����� �ڷ����� ����� ����� �� ����
        public class BaseClass
        {
            public void Start()
            {
                Console.WriteLine("Start");
            }
        }

        public void Main3<T>(T param) where T : BaseClass
        {
            param.Start();      // �Ϲ�ȭ �ڷ����� ���������� BaseClass Ŭ�����̹Ƿ�, BaseClass�� ����� ��� ���� 
        }


        static void Main(string[] args)
        {

        }
    }
}