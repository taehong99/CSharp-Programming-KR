using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Additional
{
    internal class Partial
    {
        // <Partial Type>
        // Ŭ����, ����ü, �������̽��� �����Ͽ� �����ϴ� ���
        // ��Ը� ������Ʈ���� �۾��ϴ� ��� �л��Ͽ� ������ ����

        // ��������� Player �ҽ�
        public partial class Player
        {
            private int hp;

            public void Attack() { }
            public void Defense() { }
        }

        // �����۴���� Player �ҽ�
        public partial class Player
        {
            private int weight;

            public void GetItem() { }
            public void UseItem() { }
        }


        // <Partial Method>
        // Partial Type���� Partial Method�� ���Ե� �� ����
        // ����ο� �����θ� �и��Ͽ� ���������μ� �����θ� ���� �� ����

        // ����� : �Լ��� �ִٴ� �͸� ǥ��
        public partial class Monster
        {
            public partial void Attack();
        }

        // ������ : �Լ��� ������ ����
        public partial class Monster
        {
            public partial void Attack()
            {
                // method body
            }
        }
    }
}