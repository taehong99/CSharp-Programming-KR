namespace _08._Memory
{
    internal class Program
    {
        /****************************************************************
         * 메모리 (Memory)
         *
         * 프로그램을 처리하기 위해 필요한 정보를 저장하는 기억장치
         * 프로그램은 메모리에 저장한 정보를 토대로 명령들을 수행함
         ****************************************************************/



        /****************************************************************************
         * 메모리구조
         *
         * 프로그램은 효율적인 메모리 관리를 위해 메모리 영역을 구분
         * 데이터는 각 역할마다 저장되는 영역을 달리하여 접근범위, 생존범위 등을 관리
         *****************************************************************************/

        /* <메모리 구조>
           (0x0000...) ┌─────────────┐
           낮은주소    │ 코드 영역   │ → 프로그램 코드
                       ├─────────────┤
                       │ 데이터 영역 │ → 정적변수
                       ├─────────────┤
                       │ 힙 영역     │ → 클래스 인스턴스
                       │.............│
                       │             │
                       │.............│
           높은주소    │ 스택 영역   │ → 지역변수, 매개변수
           (0xFFFF...) └─────────────┘
        */


        // <코드 영역>
        // 프로그램이 실행할 코드가 저장되는 영역
        // 데이터가 변경되지 않은 읽기 전용 데이터


        // <데이터 영역>
        // 정적변수가 저장되는 영역
        // 프로그램의 시작시 할당되며 종료시 삭제됨


        // <스택 영역>
        // 지역변수와 매개변수가 저장되는 영역
        // 함수의 호출시 할당되며 종료시 삭제됨


        // <힙 영역>
        // 클래스 인스턴스가 저장되는 영역
        // 인스턴스를 생성시 할당되며 더이상 사용하지 않을시 자동으로 삭제됨
        // 인스턴스를 참조하고 있는 변수가 없을 때 더이상 사용하지 않는다고 판단
        // 더이상 사용하지 않는 인스턴스는 가비지 컬랙터가 특정 타이밍에 수거해감


        // <변수의 접근범위와 생존범위>
        /*
                     │ 메모리영역 │ 접근 범위  │ 생존 범위
            ─────────┼────────────┼────────────┼───────────────────────────
            정적변수 │ 데이터영역 │ 모든 범위  │ 프로그램 시작에서 끝까지
            ─────────┼────────────┼────────────┼───────────────────────────
            지역변수 │ 스택영역   │ 블록 내부  │ 블록 시작에서 끝까지
            매개변수 │            │            │
            ─────────┼────────────┼────────────┼───────────────────────────
            클래스   │ 힙영역     │ 참조가능한 │ 인스턴스 생성에서
            인스턴스 │            │ 모든 범위  │ 더이상 사용하지 않을때까지
        */



        /**************************************************************************
         * 스택 영역
         *
         * 함수호출스택을 이용하여 호출과 종료에 연관되는 데이터를 저장하는 영역
         * 프로그램은 스택구조를 통해 함수에서 사용한 데이터들을 효율적으로 관리함
         **************************************************************************/

        // <함수호출스택>
        void Stack2(int a)
        {
            a = 3;
        }
        void Stack1(int a)
        {
            a = 2;
            Stack2(a);
        }

        void Main1()
        {
            int a = 1;
            Stack1(a);
        }

        /*
                          ┌───────────┐               ┌───────────┐               ┌───────────┐
                          │           │               │           │               │           │
                          │           │               │           │               ├───────────┤
                          │           │               │           │               │ Stack2()  │
                          │           │               │           │               │ a = 3     │
                          │           │               ├───────────┤               ├───────────┤
                          │           │               │ Stack1()  │               │ Stack1()  │
                          │           │               │ a = 2     │               │ a = 2     │
                          ├───────────┤               ├───────────┤               ├───────────┤
                          │ Main1()   │               │ Main1()   │               │ Main1()   │
                          │ a = 1     │               │ a = 1     │               │ a = 1     │
             Main1 호출 → └───────────┘ Stack1 호출 → └───────────┘ Stack2 호출 → └───────────┘

                          ┌───────────┐               ┌───────────┐               ┌───────────┐
                          │           │               │           │               │           │
                          │           │               │           │               │           │
                          │           │               │           │               │           │
                          │           │               │           │               │           │
                          ├───────────┤               │           │               │           │
                          │ Stack1()  │               │           │               │           │
                          │ a = 2     │               │           │               │           │
                          ├───────────┤               ├───────────┤               │           │
                          │ Main1()   │               │ Main1()   │               │           │
                          │ a = 1     │               │ a = 1     │               │           │
            Stack2 종료 → └───────────┘ Stack1 종료 → └───────────┘  Main1 종료 → └───────────┘
        */



        /**************************************************************************
         * 힙 영역
         *
         * 클래스 인스턴스가 보관하는 영역
         * 프로그램은 가비지 콜렉터를 통해 더이상 사용하지 않는 인스턴스를 수거함
         **************************************************************************/

        // <가비지 콜렉터>
        class HeapClass { }

        void Main2()
        {
            // 함수 시작시
            // 지역변수 local 이 스택 영역에 저장됨

            HeapClass local;              // 함수 시작시 이미 메모리에 할당되어 있음
            local = new HeapClass();      // 인스턴스를 힙영역에 생성하고 주소값을 local에 보관

            // 함수 종료시
            // 지역변수 local 이 함수 종료와 함께 소멸됨
            // 인스턴스 new HeapClass() 는 함수 종료와 함께 더이상 참조하는 변수가 없음
            // 인스턴스 new HeapClass() 는 가비지가 되어 가비지 컬렉터가 동작할 때 소멸됨
        }

        /*
                       ┌─────────────┐                   ┌─────────────┐
                       │             │                   │             │
                       │             │              0x56 ├─────────────┤
                       │             │               ┌──→│ HeapClass   │
                       │             │               │   │ 인스턴스    │
                       │             │               │   ├─────────────┤
                       │             │               │   │             │
                       │             │               │   │             │
                       │             │               │   │             │
                       ├─────────────┤               │   ├─────────────┤
                       | local(null) |               └───│ local(0x56) │
            함수시작 → └─────────────┘   인스턴스 생성 → └─────────────┘
                                         
                       ┌─────────────┐                   ┌─────────────┐
                       │             │                   │             │
                       ├─────────────┤                   │             │
               더이상  │ HeapClass   │                   │             │
              참조없음 │ 인스턴스    │                   │             │
                       ├─────────────┤                   │             │
                       │             │                   │             │
                       │             │                   │             │
                       │             │                   │             │
                       │             │                   │             │
                       │             │   가비지 콜렉터   │             │
            함수종료 → └─────────────┘       동작시    → └─────────────┘
        */



        /**************************************************************************
         * 데이터 영역
         *
         * 정적변수를 저장하는 영역
         * 프로그램은 시작시 데이터 영역을 생성하며 종료시 데이터 영역을 해제함
         **************************************************************************/

        // <정적 (static)>
        // 프로그램의 시작과 함께 할당, 프로그램 종료시에 소멸, 프로그램이 동작하는 동안 항상 고정된 위치에 존재
        // 정적변수 : 클래스의 이름을 통해 접근하는 변수
        // 정적함수 : 클래스의 이름을 통해 접근하는 함수
        // 정적클래스 : 정적변수와 정적함수만을 포함하는 클래스

        class Student
        {
            private static int count;
            private int id;

            public Student()
            {
                id = ++count;
            }

            public static int GetCount()
            {
                return count;
            }

            public int GetID()
            {
                return id;
            }
        }

        void Main3()
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();

            Console.WriteLine($"학생1의 ID : {student1.GetID()}");
            Console.WriteLine($"학생2의 ID : {student2.GetID()}");
            Console.WriteLine($"학생3의 ID : {student3.GetID()}");
            Console.WriteLine($"총 학생수 : {Student.GetCount()}");
        }


        static class Setting
        {
            public static int volume;
            public static void Reset() { volume = 100; }

            // public int value;            // error : 정적클래스에서 멤버변수를 포함할 수 없음
            // public void Func() { }       // error : 정적클래스에서 멤버함수를 포함할 수 없음
        }

        void Main4()
        {
            // Setting setting = new Setting();     // error : 정적클래스의 인스턴스 생성불가
            Setting.volume = 50;
            Setting.Reset();
        }


        static void Main(string[] args)
        {

        }
    }
}