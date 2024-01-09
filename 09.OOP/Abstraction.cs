using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP
{
    internal class Abstraction
    {
        /***************************************************************************
         * �߻�ȭ (Abstraction)
         *
         * Ŭ������ ������ ��� ��üȭ ��ų �� ���� ����� �߻��� ǥ������ ����
         ****************************************************************************/

        // <�߻�Ŭ���� (abstract class)>
        // �ϳ� �̻��� �߻��Լ��� �����ϴ� Ŭ����
        // Ŭ������ �߻����� ǥ���� �����ϴ� ��� �ڽĿ��� ��üȭ���� ������ ���� �����ϰ� �߻�ȭ ��Ŵ
        // �߻�Ŭ�������� ������ ��üȭ �� �� ���� �߻��Լ��� ������ �������� ����
        // �߻�Ŭ������ ����ϴ� �ڽ�Ŭ������ �߻��Լ��� �������Ͽ� ��üȭ�� ��� ��밡��
        abstract class Item                 // �߻�Ŭ���� : �ϳ� �̻��� �߻��Լ��� �����ϴ� Ŭ����
        {
            public abstract void Use();     // �߻��Լ� : Ŭ�������� ������ �������� �ʰ� ���� ����
        }

        class Potion : Item
        {
            public override void Use()
            {
                Console.WriteLine("������ ����Ͽ� ü���� ȸ���մϴ�.");
            }
        }

        class Herb : Item
        {
            public override void Use()
            {
                Console.WriteLine("�ص��ʸ� ����Ͽ� ���� �����մϴ�.");
            }
        }

        void Main1()
        {
            // Item item = new Item();      // error : �߻�Ŭ������ �ν��Ͻ� �����Ұ�

            // �߻�Ŭ������ ��üȭ�� �ڽ�Ŭ������ �ν��Ͻ� ������ �����ϸ� ���� ����� ��밡��
            Item potion = new Potion();
            potion.Use();

            Item herb = new Herb();
            herb.Use();
        }


        // <�߻�ȭ ����ǹ� 1>
        // ��ü���� �������� Ư¡�� �����ϴµ� �ǹ�
        // ������ ��üȭ�ϱ� ����� ����Ŭ������ �����ϱ� ���� �������� ���
        abstract class Animal
        {
            public abstract void Cry();     // ����Ŭ�������� �����ϱ� ����� ���
        }

        class Cat : Animal
        {
            public override void Cry()
            {
                Console.WriteLine("�߿�");   // �ڽ�Ŭ�������� ��üȭ
            }
        }

        class Dog : Animal
        {
            public override void Cry()
            {
                Console.WriteLine("�۸�");    // �ڽ�Ŭ�������� ��üȭ
            }
        }


        // <�߻�ȭ ����ǹ� 2>
        // ����Ŭ������ �������̽��� �����ϱ� ���� �������� ���
        // �߻����� ����� ��üȭ��Ű�� ���� ��� �ν��Ͻ� ������ �Ұ�
        // �̸� ���� �ڽ�Ŭ�������� ���������Լ��� ������ �����Ͽ� �Ǽ��� ����
        class Bird : Animal
        {
            public override void Cry() { }      // �������� ���� ��� ����
        }
    }
}