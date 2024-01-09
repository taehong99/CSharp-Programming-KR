using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Additional
{
    internal class Property
    {
        public class Player
        {
            private int hp;

            // <Getter Setter>
            // �ɹ������� �ܺΰ�ü�� ��ȣ�ۿ��ϴ� ��� Get & Set �Լ��� ������ �ִ� ���� �Ϲ���
            // 1. Get & Set �Լ��� ���������ڸ� �����Ͽ� �ܺο��� �ɹ������� ������ ĸ��ȭ��
            // 2. Get & Set �Լ��� ���� �ɹ������� ������ ��� ȣ�⽺�ÿ� �Լ��� �߰��Ǿ� ��������� Ȯ�� ����
            public int GetHP()
            {
                return hp;
            }
            private void SetHP(int hp)
            {
                this.hp = hp;
            }

            // <�Ӽ� (Property)>
            // Get & Set �Լ��� ������ ����ȭ
            private int mp;
            public int MP                       // mp �ɹ������� Get & Set �Ӽ�
            {
                get { return mp; }              // get : Get�Լ��� ���ҵ���
                set { mp = value; }             // set : Set�Լ��� ���ҵ���, �Ű������� value
            }

            public int AP { get; set; }         // AP �ɹ������� ����� ���ÿ� Get & Set �Ӽ�
            public int DP { get; private set; } // �Ӽ��� ���������ڸ� ���� ĸ��ȭ
            public int SP { get; } = 10;        // �б����� �Ӽ�(���ó�� ��밡��)
            public int HP => GetHP();           // �б����� �Ӽ�(����ó�� ��밡��)
        }

        void Main()
        {
            Player player = new Player();

            int playerHP = player.GetHP();
            // player.SetHP(10);            // error : SetHP�� private�� Player�� hp�� �ܺο��� ����Ұ�

            int playerMP = player.MP;       // ������Ƽ�� �̿��� mp get ����
            player.MP = 20;                 // ������Ƽ�� �̿��� mp set ����

            int playerAP = player.AP;       // ������Ƽ�� �̿��� AP get ����
            player.AP = 20;                 // ������Ƽ�� �̿��� AP set ����

            int playerDP = player.DP;       // ������Ƽ�� �̿��� DP get ����
            // player.DP = 20;              // error : DP�� set�� private�� �ܺο��� ����Ұ�

            int playerSP = player.SP;       // ������Ƽ�� �̿��� SP get ����
            // player.SP = 30;              // error : SP�� set�� ���� ����Ұ�
        }
    }
}