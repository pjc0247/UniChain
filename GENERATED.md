
__Foo__
```MSIL
.method public hidebysig static 
	void Foo (
		int32 a,
		int32 b
	) cil managed 
{
	.custom instance void InjectAttribute::.ctor(class [mscorlib]System.Type) = (
		01 00 0a 54 65 73 74 41 73 70 65 63 74 00 00
	)
	// Method begins at RVA 0x77c0
	// Code size 94 (0x5e)
	.maxstack 3
	.locals init (
		[0] object
	)

	IL_0000: ldc.i4 2
	IL_0005: newarr [mscorlib]System.Object
	IL_000a: stloc 0
	IL_000e: ldloc 0
	IL_0012: ldc.i4 0
	IL_0017: ldarg a
	IL_001b: box [mscorlib]System.Int32
	IL_0020: stelem.ref
	IL_0021: ldloc 0
	IL_0025: ldc.i4 1
	IL_002a: ldarg b
	IL_002e: box [mscorlib]System.Int32
	IL_0033: stelem.ref
	IL_0034: ldloc 0
	IL_0038: call void TestAspect::Before(object[])
	IL_003d: ldarg a
	IL_0041: ldarg b
	.try
	{
		IL_0045: call void TestManager::__patched__Foo(int32, int32)
	} // end .try
	catch [mscorlib]System.Exception
	{
		IL_004a: ldloc 0
		IL_004e: call void TestAspect::Exception(class [mscorlib]System.Exception, object[])
	} // end handler
	IL_0053: nop
	IL_0054: ldloc 0
	IL_0058: call void TestAspect::After(object[])
	IL_005d: ret
} // end of method TestManager::Foo

```

____patched_Foo__
```MSIL
.method public hidebysig static 
	void __patched__Foo (
		int32 a,
		int32 b
	) cil managed 
{
	// Method begins at RVA 0x7954
	// Code size 47 (0x2f)
	.maxstack 3
	.locals (
		[0] class [mscorlib]System.Exception
	)

	.try
	{
		IL_0000: ldarga.s a
		IL_0002: call instance string [mscorlib]System.Int32::ToString()
		IL_0007: ldstr ", "
		IL_000c: ldarga.s b
		IL_000e: call instance string [mscorlib]System.Int32::ToString()
		IL_0013: call string [mscorlib]System.String::Concat(string, string, string)
		IL_0018: call void [UnityEngine]UnityEngine.Debug::Log(object)
		IL_001d: leave IL_002e
	} // end .try
	catch [mscorlib]System.Exception
	{
		IL_0022: stloc.0
		IL_0023: ldloc.0
		IL_0024: call void [UnityEngine]UnityEngine.Debug::LogException(class [mscorlib]System.Exception)
		IL_0029: leave IL_002e
	} // end handler

	IL_002e: ret
} // end of method TestManager::__patched__Foo
```
