using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP
{
    internal class Inheritance
    {
        /**********************************************************************************
         * ��� (Inheritance)
         *
         * �θ�Ŭ������ ��� ����� ������ �ڽ�Ŭ������ �����ϴ� ���
         * is-a ���� : �θ�Ŭ������ �ڽ�Ŭ������ �����ϴ� ���������� ��� ��Ӱ��谡 ������
         **********************************************************************************/

        // <���>
        // �θ�Ŭ������ ����ϴ� �ڽ�Ŭ�������� �θ�Ŭ������ ��� ����� �ο�
        // class �ڽ�Ŭ���� : �θ�Ŭ����
        class Monster
        {
            protected string name;
            protected int hp;

            public void Move()
            {
                Console.WriteLine($"{name} ��/�� �����Դϴ�.");
            }

            public void TakeHit(int damage)
            {
                hp -= damage;
                Console.WriteLine($"{name} ��/�� {damage} �� �޾� ü���� {hp} �� �Ǿ����ϴ�.");
            }
        }

        class Dragon : Monster
        {
            public Dragon()
            {
                name = "�巡��";
                hp = 100;
            }

            public void Breath()
            {
                Console.WriteLine($"{name} ��/�� �극���� �ս��ϴ�.");
            }
        }

        class Slime : Monster
        {
            public Slime()
            {
                name = "������";
                hp = 5;
            }

            public void Split()
            {
                Console.WriteLine($"{name} ��/�� �п��մϴ�.");
            }
        }

        class Hero
        {
            int damage = 3;

            public void Attack(Monster monster)
            {
                monster.TakeHit(damage);
            }
        }

        void Main1()
        {
            Dragon dragon = new Dragon();
            Slime slime = new Slime();

            // �θ�Ŭ���� Monster�� ����� �ڽ�Ŭ������ ��� �θ�Ŭ������ ����� ������ ����
            dragon.Move();
            slime.Move();

            // �ڽ�Ŭ������ �θ�Ŭ������ ��ɿ� �ڽĸ��� ����� ���� �߰��Ͽ� ���� ����
            dragon.Breath();
            slime.Split();

            // ��ĳ���� : �ڽ�Ŭ������ �θ�Ŭ���� �ڷ������� ������ ����ȯ ����
            Hero hero = new Hero();
            hero.Attack(dragon);
            hero.Attack(slime);

            Monster monster = new Dragon();
            hero.Attack(monster);

            // �ٿ�ĳ���� : �θ�Ŭ������ �ڽ�Ŭ���� �ڷ������� ����� ����ȯ ���� (��, ������ ���)
            Dragon d = (Dragon)monster;
            // Slime s = (Slime)monster;            // error : �ν��Ͻ��� Slime�� �ƴϱ� ������ ��ȯ�� ����

            if (monster is Dragon)                  // ����ȯ�� �������� Ȯ��
            {
                Dragon isDraong = (Dragon)monster;
            }

            Dragon asDragon = monster as Dragon;    // ����ȯ�� �����ϴٸ� ����ȯ
        }


        // <��� ����ǹ� 1>
        // ����� �����ϴ� ��� �θ�Ŭ������ �ҽ��� �ڽ�Ŭ�������� ��� �����
        // �θ�Ŭ������ �ڽ�Ŭ������ ��Ӱ��谡 ������ ��� �θ�Ŭ���������� ��� ������ �ڽ�Ŭ���������� ��︲
        class Building
        {
            // �θ�Ŭ�������� ����� ������ ��� ��� �θ� ����ϴ� �ڽ�Ŭ������ ����� �����ϴ� ȿ��
        }

        class Home : Building
        {
            // �ڽ�Ŭ�������� �ڽ�Ŭ�������� ����� ����
        }

        class School : Building
        {
            // �ڽ�Ŭ�������� �ڽ�Ŭ�������� ����� ����
        }


        // <��� ����ǹ� 2>
        // ��ĳ������ ���� �ڽ�Ŭ������ �θ�Ŭ������ ����ȯ�� ������
        // �ڽ�Ŭ������ �θ�Ŭ������ �䱸�ϴ� ������ ������ ����� ������ �� ����
        class Parent
        {
            public void Func() { }
        }
        class Child1 : Parent { }
        class Child2 : Parent { }
        class Child3 : Parent { }

        void UseParent(Parent parent) { parent.Func(); }
        void Main2()
        {
            Child1 child1 = new Child1();
            Child2 child2 = new Child2();
            Child3 child3 = new Child3();

            UseParent(child1);
            UseParent(child2);
            UseParent(child3);
        }
    }
}