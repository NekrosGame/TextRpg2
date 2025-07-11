using System.Collections.Generic; // 리스트 사용을 위한 using 지시문
internal class 에서 public class로 변경하자. 어차피 다른 곳에서 사용하지 않으니까


namespace TextRpg2 //네임스페이스 정의 기초 프로젝트랑 차이점은 없으나 네임스페이스는 클래스들을 그룹화하는 방법으로, 
                   //같은 이름의 클래스를 구분할 수 있게 해준다.
{
    public class Startstory // 클래스의 정의 기초
    {
        public void Start()  // 메서드 정의 기초
        {
            Console.WriteLine("텍스트");
        }
    }
}


A a = New A(); // 인스턴스 생성
a.메서드(); // 메서드 호출
자료형 변수명 = a.변수명 // a라는 인스턴스의 변수를 가져오는 방법
                         // 단, a.변수명은 public으로 선언되어 있어야 한다. public 자료형 변수명{ get; set; } 형태로 선언해야 한다.}





public class Memo // 클래스의 정의 기초
{
	public string Title { get; set; } // 제목
	public string Content { get; set; } // 내용
	// get은 읽기 전용, set은 쓰기 전용으로 설정할 수 있다.


	public List<string> Tags { get; set; } // 태그 목록


	public Memo(string title, string content, List<string> tags)  // 생성자 정의 기초
	{
		Title = title;
		Content = content;
		Tags = tags;
	}
