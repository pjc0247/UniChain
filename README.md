UniChain
====

![img](img.PNG)
<br>
<br>

```cs
class TestAspect {
  public static void Before() {
    Debug.Log("BEFORE");
  }
  public static void After() {
    Debug.Log("AFTER");
  }
}
```
```cs
class TestObject : MonoBehaviour {

  [Inject(typeof(TestAspect))]
  public void Init() {
    Debug.Log("INIT ASSEMBLY");
  }
}
```

Chain Methods
----
__Before__<br>
메소드 호출 전에 실행됩니다.
```cs
public static void Before(object _this, object[] args) {
  // _this : this / 정적 메소드일경우 null
}
```

__After__<br>
메소드가 정상 실행된 경우에 실행됩니다.
```cs
public static void After(object _this, object[] args) {
  // _this : this / 정적 메소드일경우 null
}
```

__Exception__<br>
메소드에서 익셉션이 발생한 경우 실행됩니다.
```cs
public static object Exception(Exception e, object _this, object[] args) {
  // 익셉션을 그대로 통과시키거나, 다른 익셉션으로 변환시키거나,
  // 아니면 익셉션을 무시하고 값을 리턴시킬 수 있습니다.
  // 
  // 1. 값을 반환하지 않고, e를 그대로 throw 합니다.
  //     throw e;
  // 2. 값을 반환시킵니다.
  //     return 0;
}
```

Supported Platforms
----
* PC
* Android (MONO)

Todo
----
* Supports IL2CPP backend
