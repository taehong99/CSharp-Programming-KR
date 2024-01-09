using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Additional
{
    internal class Yield
    {
        // <yield>
        // �ݺ��⸦ ���� ������ ������ �ϳ��� ������ �� ���
        // 1. ��ȯ�� �������� ���� Ŀ�� �Ѳ����� ��ȯ�ϴ� �ͺ��� �����ؼ� ��ȯ�ϴ� ���� ȿ������ ���
        // 2. �Լ��� �������� �����͸� ������ ���
        // 3. �����ܰ������ ������� ������������ ����� �ʿ��� ���
        public IEnumerable<int> GetNumber()
        {
            yield return 10;
            yield return 20;
            yield return 30;
            yield return 40;
            yield return 50;
        }

        void Main1()
        {
            // foreach �ݺ����� IEnumerable �������̽��� ���Ե� ������ ������ �ݺ��ϴ� ���
            foreach (int num in GetNumber())
            {
                Console.WriteLine(num);     // output : 10, 20, 30, 40, 50
            }
        }

        // <yield ����>
        // yield return : �ݺ����� ������ ����
        IEnumerable<int> Repeater(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return i;
            }
        }

        // yield break : �ݺ����� ���� ����
        IEnumerable<int> UntilPlus(IEnumerable<int> numbers)
        {
            foreach (int n in numbers)
            {
                if (n > 0)
                    yield return n;
                else
                    yield break;
            }
        }

        void Main2()
        {
            foreach (int num in Repeater(5))
                Console.WriteLine(num);     // output : 0, 1, 2, 3, 4

            foreach (int num in UntilPlus(new int[5] { 1, 3, 5, -1, 4 }))
                Console.WriteLine(num);     // output : 1, 3, 5
        }
    }
}