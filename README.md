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

# Ajax 관련 내용

Ajax 관련된 부분에 ASP.NET MVC를 사용하여 아예 안 보시려는 분이 조금 계시더라구요 'ㅂ' 추가적으로 몇 개 올렸습니다. 그런데 일반적으로 Ajax를 적용하는 웹 페이지의 경우 MVC 프레임워크로 가야합니다.
자바를 사용한다면 Spring 프레임워크, 루비라면 Rails 등을 사용하는 것이 좋습니다. 다음은 PHP 코드와 JSP 코드로 가장 간단하게 같은 코드를 구현하는 방법을 언급한 내용입니다. 'ㅂ'

[PHP 버전](http://github.com)

[JSP 버전](http://github.com)

#오탈자:아직 옮기지 않아뚬
