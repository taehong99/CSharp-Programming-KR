using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._Delegate
{
    internal class Specifier
    {
        /*******************************************************************
         * ������ (Specifier)
         * 
         * ��������Ʈ�� ����Ͽ� �̿ϼ� ������ �Լ��� ����
         * �Ű������� ������ �����ڸ� �������� �Լ��� �ϼ��Ͽ� ���۽�Ŵ
         * ������ �����ִ� ������ �پ��� ����� ���� �� �ִ� �Լ��� ��������
         ********************************************************************/

        // <��������Ʈ�� �����ڷ� ���>
        // �Ű������� �Լ��� �ʿ��� ������ ����
        // ������ ������ ���� ����� ����
        void Main()
        {
            int[] array = { 3, -2, 1, -4, 9, -8, 7, -6, 5 };

            int index1 = CountIf(array, IsPositive);            // �迭 �� ���� ����� ������ ����
            int index2 = CountIf(array, IsNagative);            // �迭 �� ���� ������ ������ ����
            int index3 = CountIf(array, value => value > 5);    // �迭 �� ���� 5���� ū ������ ����
        }

        public static int CountIf(int[] array, Predicate<int> predicate)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (predicate(array[i]))
                {
                    return count++;
                }
            }

            return count;
        }

        public static bool IsPositive(int value)
        {
            return value > 0;
        }

        public static bool IsNagative(int value)
        {
            return value < 0;
        }
    }
}