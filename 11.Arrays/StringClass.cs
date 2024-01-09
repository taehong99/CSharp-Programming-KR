using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._Array
{
    internal class StringClass
    {
        // <string>
        // string�� ���ڵ��� �������� ǥ����
        // ���������� ���� �迭�� ���ؼ� ������
        // ���ڿ��� �ؽ�Ʈ�� ��Ÿ���� �� ���Ǵ� char�� ������ ����

        void Main1()
        {
            // string ���
            string str = "abcde";
            Console.WriteLine(str);     // output : abcde

            // string�� char�� ������ �������� ǥ�� : �迭ó�� �ѱ��ڿ� ���ٰ���
            Console.WriteLine(str[1]);  // output : b
            Console.WriteLine(str[3]);  // output : d

            // ��, �迭������ �����Ͽ� ���ڸ� ���� �Ұ�
            // str1[1] = 'a';           // error : ���ڿ��� �迭������ �б�����


            // char �迭�� ���ڿ��� ǥ��
            char[] array = new char[5] { 'a', 'b', 'c', 'd', 'e' };
            Console.WriteLine(array);

            foreach (char c in array)
            {
                Console.Write($"{c}");
            }
        }


        // <string�� �Һ���(Immutable)>
        // string�� Ư¡�� �ٸ� �⺻�ڷ����� �ٸ��� ũ�Ⱑ ������ ���� ���� �⺻�ڷ���
        // ������ string�� char�� �����̹Ƿ� char�� ������ ���� ũ�Ⱑ ������
        // ����, string�� ��Ÿ�� ��ÿ� ũ�Ⱑ �����Ǹ� �� ũ�Ⱑ �������� ����
        // �̿� string�� �ٸ� �⺻�ڷ����� �ٸ��� ����ü�� �ƴ� Ŭ������ �����Ǿ� ���� (��Ÿ�ӽ� ũ�⸦ ���� �� �ִ� �޸𸮴� �������� ���)
        // ��, �⺻�ڷ����� ���� �������� �����ϱ� ���� string Ŭ������ ó���� ������ó�� �����ϵ��� ����
        // �̸� �����ϱ� ���� string ���� ������ ���� ��� ������ ���� �ּҰ� ���簡 �ƴ� ���� ���縦 ����
        // ��������� ������ ��ü�� �����ϴ� ���������� ��������� �������� ����ϱ� ������ string�� �����Ǹ� ������ �� �������ϴ� '�Һ���'�� ����

        void Main2()
        {
            string str1 = "abced";      // �������� abced ���ڿ��� �����ϸ� �̸� str�� ������
            str1 = "abc";               // ���ο� �������� abc ���ڿ��� �����ϸ� �̸� str�� ������
            str1 = str1 + "123";        // ���ο� �������� abc123 ���ڿ��� �����ϸ� �̸� str�� ������

            string str2 = str1;         // class ������ string�� ������ó�� ���Ǿ�� �ϱ� ������
                                        // �������� abc123 ���ڿ��� �����Ͽ� str2�� �����ϵ��� ��
        }


        // <�޸� ����ȭ>
        // string �� �Һ��� Ư¡�� �����Ƿ� ���ο� �����͸� string�� �Ҵ��� ������ ���� �����ʹ� ������
        // �� �������� �������� �����ʹ� �������÷����� ����� �Ǹ�, �̸� �ݺ������� ������ ��� �������÷��Ϳ� �δ��� ��
        // ���� string�� �Ҵ��� �ݺ������� �����ϴ� ��츦 �����ؾ� ���α׷��� �������� ���� �� ����
        void Main3()
        {
            // ���ڿ� ���̱� ������ ���
            // +���� : �������� �ʴ� ���, �������÷��Ϳ� �δ��� ��
            // "abc123def456" ���ڿ��� ���� ���� "abc", "def", "abc123", "abc123def" �� ������ �߻�
            string str = "abc" + 123 + "def" + 456;
        }


        // <String.Format>
        // �������÷��Ϳ� �δ���� �ʵ��� ����� ���ڿ� �����
        // ���α׷� ���� �� �� �׸��� �Ű����� ����� ������ ǥ���� �ٲ�
        void Main4()
        {
            string str = string.Format("abc{0}def{1}", 123, 456);
        }


        // <���ڿ� ����>
        // String.Format�� ������ ǥ��
        // ���ڿ� ������ �����ϴ� ���� �б� ���� ���� ������ ����
        void Main5()
        {
            string str = $"abc{123}def{456}";
        }


        // <���ڿ� ���� �� ����>
        // ���ڿ� ������ ǥ���ϴµ� ���� ���ݰ� ������ ����
        void Main6()
        {
            // ���ڿ� ����
            Console.WriteLine($"{"ABC",-5}!");              // output : ABC  !
            Console.WriteLine($"{"ABC",+5}!");              // output :   DEF!
            Console.WriteLine($"{"ABC",-5}!{"DEF",+5}!");   // output : ABC  !  DEF!
            Console.WriteLine($"{"ABC",+5}!{"DEF",-5}!");   // output :   ABC!DEF  !


            // ���ڿ� ����
            // - 10���� ���� -
            Console.WriteLine($"{255:D5}");                 // output : 00255
            Console.WriteLine($"{0xFF:D5}");                // output : 00255

            // - 16���� ���� -
            Console.WriteLine($"{255:X5}");                 // output : 000FF
            Console.WriteLine($"{0xFF:X5}");                // output : 000FF

            // - ���� ���� -
            Console.WriteLine($"{123456789:N2}");           // output : 123,456,789.00

            // - �����Ҽ��� ���� -
            Console.WriteLine($"{0.555:F2}, {0.554:F2}");   // output : 0.56, 0.55

            // - �ε��Ҽ��� ���� -
            Console.WriteLine($"{123.4567:E3}");            // output : 1.235E+002


            // ���ڿ� ���ݰ� ����
            Console.WriteLine($"Text:{123.456,+8:F2}");    // output : Text:  123.46
        }


        // <StringBuilder>
        // ���� ���۸� ����ϴ� ������� �������÷��Ϳ� �δ���� �ʵ��� �����
        void Main7()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append((char)65 + i);
                sb.Append(":");
                sb.Append(65 + i);
                sb.AppendLine();
            }
            string str = sb.ToString();
        }
    }
}