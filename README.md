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
