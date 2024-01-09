using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._Event
{
    internal class Architecture
    {
        /****************************************************************
         * �̺�Ʈ�� ����ǹ�
         * 
         * �̺�Ʈ�� ����� ��� Ŭ������ ��������Ģ�� ��ų �� ������
         * �Ϸ��� ����� �߻��� Ÿ�ֿ̹��� ������ ������ �� ����
         ****************************************************************/

        public class Call
        {
            // <Call ���>
            // �Ϸ��� ����� �߻��� ������ ����� �Լ��� ȣ���Ͽ� ����
            // ���� : ���ʿ��� ���� ���� �Ϸ��� ����� �߻��� Ÿ�ֿ̹� ó�� ����
            // ���� : �߰� ��� ���߽� Ŭ������ �����ؾ��ϴ� ��������� ��Ģ�� ������

            public class Player
            {
                public int hp = 100;

                public UI ui;

                public void Hit(int damage)
                {
                    hp -= damage;
                    Console.WriteLine($"�÷��̾ �������� �޾� ü���� {hp} �� �Ǿ����ϴ�.");

                    // Ŭ�������� ������ ��ɵ��� ���� ȣ���ؾ���
                    // ���� ���ο� ����� �߰��Ǵ� ��� ����ؼ� ������ �κ�
                    ui.SetHP(hp);
                }
            }

            public class UI
            {
                public void SetHP(int hp)
                {
                    Console.WriteLine($"UI�� ü��ǥ�ø� {hp} ���� �����մϴ�.");
                }
            }
        }


        public class Polling
        {
            // <Polling ���>
            // ��󿡼� �Ϸ��� ��� �߻��� Ȯ���ϱ� ���� ����ؼ� ��������� Ȯ��
            // ���� : �߰� ��� ���߽ÿ��� Ŭ������ �������� �ʾ� ��������� ��Ģ�� �ؼ���
            // ���� : ��������� ���� ��쿡�� ��� Ȯ���ؾ��ϴ� ���ʿ��� ������ �߻�

            public class Player
            {
                public int hp = 100;

                public void Hit(int damage)
                {
                    hp -= damage;
                    Console.WriteLine($"�÷��̾ �������� �޾� ü���� {hp} �� �Ǿ����ϴ�.");
                }
            }

            public class UI
            {
                public Player player;

                // UI�� �����ϱ� ���� �ֱ������� �����ؾ���
                // ������ ���� ��� UI���� Ȯ���ϴ� ������ ���� �����Ϳ� �ٸ� �� ����
                public void CheckHP()
                {
                    Console.WriteLine($"UI�� ü��ǥ�ø� {player.hp} ���� �����մϴ�.");
                }
            }
        }

        public class Event
        {
            // <Event ���>
            // �Ϸ��� ����� �߻����� �� ������ ����� �����ϰ� ��� �߻��� ȣ���Ͽ� ����
            // ���� : ��������� ��Ģ�� ��������, ���ʿ��� ������ �ʿ�� ���� ����
            // ���� : �̺�Ʈ�� �����ϱ� ���� �߰����� �ҽ��� �ۼ��ؾ� ��

            public class Player
            {
                public int hp = 100;

                public event Action<int> OnChangeHP;

                public void Hit(int damage)
                {
                    hp -= damage;
                    Console.WriteLine($"�÷��̾ �������� �޾� ü���� {hp} �� �Ǿ����ϴ�.");

                    // ����� �߻��� ������ �̺�Ʈ�� ����� ��ü���� �Լ��� ȣ��
                    // �̺�Ʈ�� ������ ��� ���ο� ����� �߰��Ǿ ������ �ʿ䰡 ����
                    if (OnChangeHP != null)
                        OnChangeHP(hp);
                }
            }

            public class UI
            {
                // �̺�Ʈ �߻� ������ ȣ����� �Լ�
                // �̺�Ʈ �߻� ������ �ݵ�� ȣ����ϱ� ������ �ֱ����� ������ �ʿ����
                public void SetHP(int hp)
                {
                    Console.WriteLine($"UI�� ü��ǥ�ø� {hp} ���� �����մϴ�.");
                }
            }
        }
    }
}