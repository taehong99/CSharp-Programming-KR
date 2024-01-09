using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP
{
    internal class Polymorphism
    {
        /***************************************************************************
         * ������ (Polymorphism)
         *
         * ��ü�� �Ӽ��̳� ����� ��Ȳ�� ���� �������� ���¸� ���� �� �ִ� ����
         ****************************************************************************/

        // <������>
        // �θ�Ŭ������ ����� �ڽ�Ŭ������ ��Ȳ�� ���� �������� ���¸� ���� �� �ִ� ����
        class Car
        {
            protected string name;
            protected int speed;

            public void Move()
            {
                Console.WriteLine($"{name} ��/�� {speed} �� �ӵ��� �̵��մϴ�.");
            }
        }

        class Truck : Car
        {
            public Truck()
            {
                name = "Ʈ��";
                speed = 30;
            }
        }

        class SportCar : Car
        {
            public SportCar()
            {
                name = "������ī";
                speed = 100;
            }
        }

        void Main1()
        {
            Car car1 = new Truck();
            Car car2 = new SportCar();

            car1.Move();    // Ʈ�� ��/�� 30 �� �ӵ��� �̵��մϴ�.
            car2.Move();    // ������ī ��/�� 100 �� �ӵ��� �̵��մϴ�.
        }


        // <�����Լ��� �������̵�>
        // �����Լ�   : �θ�Ŭ������ �Լ� �� �ڽ�Ŭ������ ���� ������ �� �� �ִ� �Լ��� ����
        // �������̵� : �θ�Ŭ������ �����Լ��� ���� �Լ��̸��� �����Ű������� �������Ͽ� �ڽĸ��� ������ ����
        class Skill
        {
            public virtual void Execute()       // �����Լ�
            {
                Console.WriteLine("��ų ���� ���ð��� �����Ŵ");
            }
        }

        class FireBall : Skill
        {
            public override void Execute()      // �������̵�
            {
                base.Execute();      // base : �θ�Ŭ������ ����Ŵ
                Console.WriteLine("���濡 ȭ������ ����");
            }
        }

        class Dash : Skill
        {
            public override void Execute()
            {
                Console.WriteLine("���濡 �ٰŸ��� ������ �̵�");
            }
        }

        void Main2()
        {
            Skill fireBall = new FireBall();
            fireBall.Execute();     // �ڽ�Ŭ������ �Լ��� ȣ���
            // ��ų ���� ���ð��� �����Ŵ
            // ���濡 ȭ���� ����

            Skill dash = new Dash();
            dash.Execute();         // �ڽ�Ŭ������ �Լ��� ȣ���
            // ���濡 �ٰŸ��� ������ �̵�
        }


        // <������ ����ǹ� 1>
        // ���ο� Ŭ������ �߰��ϰų� Ȯ���� �� ���� �ڵ忡 ������ �ּ�ȭ��
        // ���ο� Ŭ������ ���� �� ������ �ҽ��� �������� �ʾƵ� ��
        class Player
        {
            Skill skill;

            public void SetSkill(Skill skill)
            {
                this.skill = skill;
            }

            public void UseSkill()
            {
                skill.Execute();    // skill Ŭ������ �������� Ȯ���� ��� ����
            }
        }


        // <������ ����ǹ� 2>
        // Ŭ���� ���� �������� �ٿ� Ȯ�强�� ����
        class SkillContents : Skill
        {
            public override void Execute()
            {
                base.Execute();
                // ���α׷��� Ȯ���� ���� ����Ŭ������ ����ϴ� Ŭ������ ����
            }
        }
    }
}