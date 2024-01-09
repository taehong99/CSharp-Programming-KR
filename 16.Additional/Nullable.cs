using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Additional
{
    internal class Nullable
    {
        void Main()
        {
            // <Nullable Ÿ��>
            // �������� �ڷ������� null�� ���� �� ����
            // �����Ŀ��� null�� �Ҵ��� �� �ִ� Nullable Ÿ���� ����
            bool? b = null;
            int? i = 20;
            if (b != null) Console.WriteLine(b);    // b ���� null
            if (i.HasValue) Console.WriteLine(i);   // i ���� �����Ƿ� 20 ���


            // <Null ���ǿ�����>
            // ? ���� ��ü�� null �� ��� null ��ȯ
            // ? ���� ��ü�� null �� �ƴѰ�� ����
            NullClass instance = null;
            // instance.Func();                     // ���ܹ߻� : instance�� null �̹Ƿ� ������ ��ü�� ����
            Console.WriteLine(instance?.value);     // instance?.value�� null ��ȯ
            instance?.Func();                       // instance?.Func()�� null ��ȯ

            instance = new NullClass();
            Console.WriteLine(instance?.value);     // instance?.value�� 5 ��ȯ
            instance?.Func();                       // instance?.Func()�� �Լ� ȣ��


            // <Null ���տ�����>
            // ?? ���� ��ü�� null �� ��� ?? ���� ��ü ��ȯ
            // ?? ���� ��ü�� null �� �ƴѰ�� ���� ��ü ��ȯ
            int[] array = null;
            int length = array?.Length ?? 0;        // �迭�� null �ΰ�� 0 ��ȯ, �ƴѰ�� �迭�� ũ�� ��ȯ


            // <Null �����Ҵ翬����>
            // ??= ���� ��ü�� null �� ��� ??= ���� ��ü�� �Ҵ�
            // ??= ���� ��ü�� null �� �ƴѰ�� ??= ���� ��ü�� �Ҵ����� ����
            NullClass nullClass = null;
            nullClass ??= new NullClass();          // nullClass �� null�̹Ƿ� ���ο� �ν��Ͻ� �Ҵ�
            nullClass ??= new NullClass();          // nullClass �� null�� �ƴϹǷ� ���ο� �ν��Ͻ� �Ҵ��� ���� ����
        }

        public class NullClass
        {
            public int value = 5;

            public void Func() { }
        }
    }
}