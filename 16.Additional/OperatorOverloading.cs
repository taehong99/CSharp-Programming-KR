using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Additional
{
    internal class OperatorOverloading
    {
        /**********************************************************************
         * ������ ������ (Operator Overloading)
         *
         * ��������� �ڷ����̳� Ŭ������ �����ڸ� �������Ͽ� ���� �ǹ̷� ���
         **********************************************************************/

        // <������ ������>
        // �⺻�������� ������ �Լ��� �������Ͽ� ����� ����
        // �⺻�����ڸ� ȣȯ���� �ʴ� ��������� �ڷ����� �⺻������ ����� ������

        public struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            // ������ �����Ǹ� ���� �⺻������ ��� ����
            public static Point operator +(Point left, Point right)
            {
                return new Point(left.x + right.x, left.y + right.y);
            }
        }


        void Main()
        {
            Point point = new Point(3, 3) + new Point(2, 5);        // point == (5, 8)
            // Point point = new Point(3, 3) - new Point(1, 2);     // error : - �⺻�����ڴ� �����ǵǾ� ���� ����
        }
    }
}