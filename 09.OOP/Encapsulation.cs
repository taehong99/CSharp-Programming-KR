using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP
{
    internal class Encapsulation
    {
        /**********************************************************************
         * ĸ��ȭ (Encapsulation)
         *
         * ��ü�� ������ ������� ���� ���� �ǹ�
         * ��ü�� ���� ������ ����� �����, ����� ������ ��ɸ��� �׼��� ���
         **********************************************************************/

        // <ĸ��ȭ>
        // ��ü�� ������ ������� ���� ��, ��ü�� ������ ����� ������ ǥ����
        // ���Ǽ����� ��ü�� ǥ���ϱ� ���� ��ü�� ������ ������ �ൿ�� ���� �����ϸ� �̸� ���� ��ü�� ��ȣ�ۿ�
        class Capsule
        {
            int variable;           // ������� : ��ü�� ������ ǥ��
            void Function() { }     // ����Լ� : ��ü�� ����� ǥ��
        }


        // <����������>
        // �ܺο��� ������ ������ ��������� ����Լ��� �����ϴ� ���
        // ���������ڸ� �������� �ʴ� ��� �⺻���������ڴ� private
        // public    : �ܺο����� ���ٰ���
        // private   : ���ο����� ���ٰ���
        // protected : ����� Ŭ�������� public, �׿ܿ��� private
        class AccessSpecifier
        {
            public int publicValue;
            private int privateValue;

            void Function()
            {
                publicValue = 1;            // ���ٰ���
                privateValue = 2;           // ���ٰ���
            }
        }

        void Main1()
        {
            AccessSpecifier instance = new AccessSpecifier();
            instance.publicValue = 3;       // ���ٰ���
            // instance.privateValue = 4;   // ���ٺҰ�
        }


        // <��������>
        // ��ü ������ �־ �ܺο��� ����ϱ� ���ϴ� ��ɰ� ����ϱ� ������ �ʴ� ����� �����ϱ� ���� ���
        // ����ڰ� ��ü�� ����ϴµ� �־ �ʿ��� ��ɸ��� Ȯ���ϱ� ���� �뵵�̸�
        // �ܺο� ���� ������ ���� �ʱ� ���ϴ� ����� ���߱� ���� �뵵�̱⵵ ��
        class Bank
        {
            int balance;

            public void Save(int money)
            {
                balance += money;
            }

            public void Load(int money)
            {
                balance -= money;
            }
        }

        void Main2()
        {
            Bank bank = new Bank();

            // �ܺο��� Bank�� balance�� ���������� ���ٺҰ�
            // bank.balance = 0;

            // �ܺο����� Bank���� �ǵ��� Save�� Load�� ���� Bank�� �ٷ�� ����
            bank.Save(20000);
            bank.Load(10000);
        }


        // <ĸ��ȭ ����ǹ� 1>
        // ĸ��ȭ�� Ŭ������ �ܺο��� ����ϱ� ���� �������̽����� �����Ͽ� ���⼺ ����
        // ĸ��ȭ�� Ŭ������ ���������� ��� �����Ǿ����� ���� ��밡��
        class VeryComplicatedObject
        {
            // ĸ��ȭ�� Ŭ������ private�� �ܺο��� ���ٺҰ��ϹǷ� ����� �� ����
            int veryComplicatedValue1;
            int veryComplicatedValue2;
            int veryComplicatedValue3;

            void VeryComplicatedFunction1() { }
            void VeryComplicatedFunction2() { }
            void VeryComplicatedFunction3() { }

            // ĸ��ȭ�� Ŭ������ public�� �ܺο��� ���ٰ����ϹǷ� ����� �����ϴ� ���
            public void UseThisFunction() { }
        }


        // <ĸ��ȭ ����ǹ� 2>
        // ĸ��ȭ�� Ŭ������ �ܺο��� ������ �ʴ� �������κ��� ��ȣ�� �� �־� ����� ����� ����
        class IntArray
        {
            int[] array = new int[10];

            public void SetValue(int index, int value)
            {
                if (index < 0 || index >= 10)
                    return;

                array[index] = value;
            }
        }
    }
}