Module Module1

    Sub Main()
        'Dim obj As ConsoleTest
        'obj = New ConsoleTest()
        'obj.Main()
        '代表启动应用程序的命令行
        'Dim strCommand As String = Command()
        '获取和设置当前目录(该进程从中启动的目录)的完全限定目录Environment.CurrentDirectory
        '获取模块的完整路径Diagnostics.Process.GetCurrentProcess().MainModule.FileName
        Dim strCumentDirectory As String = Diagnostics.Process.GetCurrentProcess().MainModule.FileName
        Console.WriteLine(strCumentDirectory)
        Console.ReadLine()
        '结束程序
        'Exit Sub
        '随机数
        Dim rand As Random = New Random
        'Next()——返回一个非负随机整数。
        'Next(maxValue) ——返回一个小于所指定最大值的非负随机整数
        'Next(minValue,maxValue)——返回在指定范围内的任意整数
        'NextDouble：返回一个大于或等于 0.0 且小于 1.0 的随机双精度型浮点数。
        Dim I As Integer = rand.Next(0, 100)
        'Math函数
        '比较两个值返回大值
        'Math.Max()
        '比较两个值返回小值
        'Math.Min()
        '返回绝对值
        'Math.Abs()
        '返回π
        'Math.PI()
        '数组
        Dim arrlist As New ArrayList
        '返回数组当前的大小
        Dim I_One As Integer = arrlist.Capacity()
        '返回存储数据的数量
        Dim I_Count As Integer = arrlist.Count()
        '返回指定数组
        Dim v As Object = arrlist.Item(1)
        '加入数组内容
        Dim I_Add As Integer = arrlist.Add(v)
        '清空数组内容
        arrlist.Clear()
        '返回指定对象的位置
        Dim I_indexOf As Integer = arrlist.IndexOf(v)
        '指定位置添加内容 (位置，内容)
        arrlist.Insert(2, v)
        '删除指定对象
        arrlist.Remove(v)
        '删除指定位置
        arrlist.RemoveAt(1)
        '排序
        arrlist.Sort()
        '全部或部分元素复制到一个数组中
        arrlist.ToArray()
        '将容器和内容相等
        arrlist.TrimToSize()

        'Queue（队列）和Stack（栈）
        Dim Queue_ As New Queue

        'Count 数量 Dim I_QUEUE As Integer = Queue_.Count()
        'Clear 清除队列 Queue_.Clear()
        '删除一个对象并返回 Dim v_Queue = Queue_.Dequeue()
        '增加一个对象Queue_.Enqueue(v)
        '查了队列下一个项目，不删除 dim v As Object = Queue_.Peek()

        Dim Stack_ As New Stack
        'Count 数量 Dim I_QUEUE As Integer = Stack_.Count()
        'Clear 清除队列 Stack_.Clear()
        '删除下一个项目 Dim v As Object = Stack_.Pop()
        '增加一个对象Stack_.Push(v)
        '查了队列下一个项目，不删除 dim v As Object = Stack_.Peek()


    End Sub

End Module
