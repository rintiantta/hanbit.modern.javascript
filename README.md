#HTML5 Programming Example

현재 만들고 있으므로 링크 연결 안 됩니다. ㅇㅂㅇ

`모던 웹을 위한 JavaScript + jQuery 입문『한빛미디어, 2011』`에 사용된 예제입니다.
그냥 위에 zip 파일 눌러서 다운 받으면 됩니다.

질문은 issues에 글을 남겨주시면 됩니다.
모두 함께 답변을 해주세요!
우리 함께 만들어가는 좋은 대한민국 개발 세상 "ㅁ" ....

# 중요 변경 사항
* jQuery live() 메서드

jQuery 1.9버전에서에 `live() 메서드`가 공식적으로 사라졌습니다.
`on() 메서드`로 모든 것이 통합되었습니다.
__427페이지부터 430페이지__(live() 메서드)까지의 내용을 일단 눈으로 읽고
__431페이지__(on() 메서드)를 보면서 예제를 작성하는 것을 추천합니다.

* jQuery die() 메서드

jQuery 1.9버전에서 마찬가지로 `die() 메서드`가 사라졌습니다.
`off() 메서드`로 이름이 완전히 변경되었답니다.

* jQuery toggle() 메서드

jQuery 1.9버전에서 `toggle() 메서드`도 제거되었습니다.
나름 유용한 메서드이므로 jQuery 라이브러리 1.8버전의 `toggle() 메서드`를 `cycle() 메서드`로 변경해서 다음 페이지에 올렸으니 확인해주시기 바랍니다.

[jQuery.cycle.js](https://github.com/rintiantta/jquery.cycle.js)

사용 방법은 다음과 같습니다.
```javascript
// 기존 toggle() 메서드 사용
$('h1').toggle(function () { }, function () { });
```
```javascript
// cycle() 메서드 사용
$('h1').cycle(function () { }, function () { });
```

* input 태그의 checked 속성
jQuery 라이브러리 1.9버전 이하에서는 다음과 같이 attr() 메서드를 사용해 체크 상태를 변경할 수 있었습니다.

```html
<script src="http://code.jquery.com/jquery-1.9.1.js"></script>
<script>
    $(document).ready(function () {
        $('#all_check').change(function () {
            if (this.checked) {
                $('#check_item').find('input').attr('checked', true);
            } else {
                $('#check_item').find('input').attr('checked', false);
            }
        });
    });
</script>
```
하지만 jQuery 라이브러리 1.9버전부터는 반드시 prop() 메서드를 사용해서만 체크 상태를 변경할 수 있습니다.
음... 뭔가 이상하게 바뀌어버렸엉... 전혀 예상하지 못한 부분이 바뀌는군요....
```html
<script src="http://code.jquery.com/jquery-1.9.1.js"></script>
<script>
    $(document).ready(function () {
        $('#all_check').change(function () {
            if (this.checked) {
                $('#check_item').find('input').prop('checked', true);
            } else {
                $('#check_item').find('input').prop('checked', false);
            }
        });
    });
</script>
```
##ECMAScript5 관련 내용
ECMAScript5 관련 내용은 책에 표기되어 있듯
HTML5를 지원하는 브라우저에서만 작동합니다.
따라서 인터넷 익스플로러 8 버전 이하에서는 작동하지 않습니다. 참고하세용 'ㅂ'

# Ajax 관련 내용
Ajax 관련된 부분에 ASP.NET MVC를 사용하여 아예 안 보시려는 분이 조금 계시더라구요 'ㅂ' 추가적으로 몇 개 올렸습니다. 그런데 일반적으로 Ajax를 적용하는 웹 페이지의 경우 MVC 프레임워크로 가야합니다.
자바를 사용한다면 Spring 프레임워크, 루비라면 Rails 등을 사용하는 것이 좋습니다. 다음은 PHP 코드와 JSP 코드로 가장 간단하게 같은 코드를 구현하는 방법을 언급한 내용입니다. 'ㅂ'
[PHP 버전](http://github.com)
[JSP 버전](http://github.com)
#오탈자:아직 옮기지 않아뚬
##주요 오탈자
예제를 진행하는데 타격을 줄 수 있는 예제 오류와 오탈자가 있습니다.

###Page. 51
예제를 통해 살펴보겠습다. => 예제를 통해 살펴보겠습니다.

###Page. 116
for in 반복문을 사용하는 예제를 만들고자 적었는데...
실수를 했군요. 인터넷 익스플로러 8 버전 이하에서는 작동하지 않습니다... OTL
for in 반복문을 for 반복문으로 교체해주세요.

###Page. 123
띄어쓰기 오류가 있습니다.
returnfunction()으로 되어 있는 것을 return function()으로 수정해주세요..!
 
###Page. 164 - glasstaiji님 발견!
코드 6-35에서 Rectangle 생성자 함수에 캡슐화를 적용 했는데 "ㅁ" ....
캡슐화에 치중한 나머지....생성 시의 처리를 안 했군요.
생성할 때도 음수가 들어가지 못하게
```javascript
if(w <0) { throw '길이는 음수일 수 없습니다.' }
if(h <0) { throw '길이는 음수일 수 없습니다.' }
```
를 Rectangle 생성자 함수의 가장 상단에 넣어야합니다!

###Page. 167
코드 6-37이 잘못 들어갔습니다. 코드 6-37 뒤에 다음 부분이 추가되어야 합니다.
```html
<script>
    // 생성자 함수를 선언합니다.
    function Square(length) {
        this.base = Rectangle;
        this.base(length, length);
    }
    Square.prototype = Rectangle.prototype;
</script>
```

###Page. 168 - 안요한님 발견!
168페이지의 코드 6-38의 
```javascript
Square.prototype = Rectangle.prototype; // (168페이지 마지막 줄)을
```
다음 코드로 변경합니다.
```javascript
Square.prototype = Rectangle.prototype;
Square.prototype.constructor = Square;
```

###Page. 171
위에서 두 번째 줄에 코드 6-1이라고 쓰여있는데
코드 6-1이 아니라 코드 6-38입니다. ㅠㅁㅜ

###Page. 177
이 경우에 주의할 점은 6.19절에서 살펴볼 메서드지만
-> 이 경우에 주의할 점은 6.18절에서 살펴볼 메서드지만

###Page. 197
표 7-3에 오타가 있습니다. ㅠㅁㅜ
POSITIVE_INFINITY가 양의 무한대 숫자
NEGATIVE_INFINITY가 음의 무한대 숫자입니다.
 
###Page. 215
ㅇㅂㅇ.... Date 객체 출력해도 월이 조금 이상하게 나오지요 ;ㅁ; .. ?
월이 0부터 시작입니다. ;ㅁ; ... 실수를 했군요. OTL 
 
###Page. 244
코드 8-9 주석에 오타가 있습니다.
"// 1초마다 함수를 실행합니다."가 아니고 "// 2초마다 함수를 실행합니다."입니다.

###Page. 289
코드 10-11, 코드 10-12, 코드 10-13에 오류가 있습니다. ㅎㄷㄷ...
button_A -> buttonA
button_B -> buttonB
counter_A -> counterA
counter_B -> counterB
이렇게 변수 이름에 실수가 있으므로 좌측에 있는 것을
우측의 것으로 바꾸어 주세요 ㅠㅁㅜ

###Page. 364
"이 절에서 배울 메서드는 $.extent() 메서드입니다."를
"이 절에서 배울 메서드는 $.extend() 메서드 입니다."로 바꾸어야합니다. 'ㅁ'

###Page. 366
366페이지에 "계속 쓰는 녀석인데 너무 길어요!" 
1. 부분 위에 코드 13-39를 코드 13-38로 바꾸어야합니다.
2. 부분 아래에 코드 13-38을 코드 13-39로 바꾸어야합니다.

###Page. 436
그림 16-14의 왼쪽 것이 mouseover 이벤트
오른쪽 것이 mouseenter 이벤트입니다. 'ㅂ'

###Page. 438
코드 바로 다음에 나오는 글에
"코드 16-33처럼 textarea 태그에"나오는 부분의 코드를
코드 16-37로 바꾸어야합니다.  'ㅂ'

###Page. 443
마지막에 언급했듯이 무한스크롤이 모바일 페이지에서는 숫자 오차가 있어서 안 됩니다.
아이폰의 경우는 30 픽셀의 오차가 있고 안드로이드 폰의 경우는 0픽셀 ~ 200픽셀 사이의 오차가 있으므로
조건 부분을 다음과 같이 입력하세요.
```javascript
if (scrollHeight + 200 >= documentHeight)
```
파이어폭스에서는 가끔 1의 오차를 보이는군요.
 
###Page. 490
다음 부분을
```javascript 
// 초기 슬라이더 위치 지정
var randomNumber = Math.round(Math.random() * 5);
```
다음으로 수정합니다. 'ㅁ'
```javascript
// 초기 슬라이더 위치 지정
var randomNumber = Math.round(Math.random() * 4);
```
###page. 520
이 책에서 가장 큰 오탈자라고 생각하는 부분입니다. 'ㅂ' ...
내용을 하나라도 더 써야지 했다가 예제 합치는 과정에서 오류가 난 부분입니다.
520 페이지를 보시면 다음과 같은 부분이 있습니다.
```javascript
window.onload = function () {
    // XMLHttpRequest 객체를 생성합니다.
    var request = new XMLHttpRequest();
    request.open('GET', '/Home/ActionWithData', false);
 
    // Ajax를 수행합니다.
    request.send('name=RintIanTta&age=21');
 
    // 출력합니다.
    document.body.innerHTML = request.responseText;
};
```
이렇게 해야 POST 요청으로 데이터를 전달할 수 있습니다.... 죄송합미다... ㅠㅁㅜ
```javascript
window.onload = function () {
    // XMLHttpRequest 객체를 생성합니다.
    var request = new XMLHttpRequest();
    request.open('POST', '/Home/ActionWithData', false);
   
    // Ajax를 수행합니다.
    request.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');
    request.send('name=RintIanTta&age=21');
   
    // 출력합니다.
    document.body.innerHTML = request.responseText;
};
```
또는 GET 요청으로 바꾸어서 다음과 같이 만드셔도 됩니다. 'ㅁ' ㅎㅎ
```javascript
window.onload = function () {
    // XMLHttpRequest 객체를 생성합니다.
    var request = new XMLHttpRequest();
    request.open('GET', '/Home/ActionWithData?name=RintIanTta&age=21', false);
 
    // Ajax를 수행합니다.
    request.send();
 
    // 출력합니다.
    document.body.innerHTML = request.responseText;
};
```
###page. 533
코드 20-19에 반복문 내부 3번째 줄
```javascript
var part = part['people']['person'][i].part
```

```javascript
var part = json['people']['person'][i].part
```
로 수정합니다. 'ㅁ'

###Page. 573
코드 22-19의 요청을 보내면 인터넷 익스플로러에서는 업데이트가 안되지요 ㅇㅂㅇ...
'/Home/GetPeopleJSON?dummy=' + new Date().getTime()
이렇게 요청 URL을 작성해주세요 ~_~ ㅎ...ㅠㅁㅜ 이걸 깜빡하다니 흐허허

###Page. 585 - 강동원님 발견!
코드23-13에 아래에서 3번째 줄을 보시면
$('#paging_button').append($add) 로 되어있습니다.
$('.paging_button').append($add) 로 수정합니다.

###Page. 655
그림 27-7에 맨 아래 PubliseDate 가 아니라 PublishDate 입니다. ;ㅁ; 흐허허

###Page. 863
인덱스에 I가 없고 H가 두번있죠 'ㅁ' ....

##사소한 오탈자
예제를 진행하는데 타격을 줄 수 있는 예제 오류와 오탈자가 있습니다.

###Page. 6
처음에 나오는 코드의 들여쓰기가 안 되어 있지요 'ㅂ' ....

###Page. 32
아래에 있는 HTML 기본 코드 중간에 "ㄱ"이 들어가 있습니다.
원고 치다가 잠에 들어 키보드를 눌렀나 봅니다...
