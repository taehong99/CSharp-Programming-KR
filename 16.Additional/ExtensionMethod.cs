using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Additional
{
    internal static class ExtensionMethod
    {
        // <Ȯ��޼���>
        // Ŭ������ ���� ������ �������� �ʰ� ���� ���Ŀ� �Լ��� �߰��� �� ����
        // ����� ���Ͽ� ������ �ʰ� �߰����� �Լ��� ���� ����
        // �����Լ��� ù��° �Ű������� this Ű���� �� Ȯ���ϰ��� �ϴ� �ڷ����� �ۼ�

        public static int WordCount(this string str)
        {
            return str.Split(' ').Length;
        }

        public static void Main1()
        {
            string str = "hello world!";

            // Ȯ��޼��带 ���Ͽ� �⺻ string�� ���� �Լ��� ��� ����
            Console.WriteLine(WordCount(str));      // �����Լ� ���
            Console.WriteLine(str.WordCount());     // Ȯ��޼��� ǥ��
        }
    }
}