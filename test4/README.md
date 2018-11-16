#第四次作业概述

##作业要求
- 本实验在上一个实验（实验3）的基础上进行。要求对每个考生的答卷（docx文档）进行自动阅卷并评分，最后把评分写入一个二进制文件中。
- 样例文件在老师的test4目录中。本实验的输入是：原题.docx，标准答案.docx，以及考生答案目录(students_answer)，在考生答案目录中存放的是考生的作答文件，每个考生文件的命名方式是考号_姓名.docx。程序必需能够自动对考生答案目录中的每个文件进行评分。
- 本实验的输出是一个二进制成绩结果文件。比如result.dat，这个文件的中存放了每个考生的个人信息和成绩。本实验必须能够写result.dat文件，并且把文件内容再正确的读出来。

##主要内容   
-  这一次的作业部分功能在之前的作业中已经涉及到并且实现，因此可以参考之前的作业。
-  本次作业中的主要内容如下：
   
   创建windows窗体应用程序
    
   LCS算法
   
   文件的读写
    
##整体过程
  创建窗体应用程序
  
    第一步要拖动splitContainer进主体中，再将Orientation 的值设置为Horizontal，然后使得容器呈上下排布，接着拖动按钮，文本框，标签等。
    通过双击对应的按键可以进入相应的事件，在这里进行逻辑响应事件等的设置。

  LCS算法的用途
  
     利用LCS算法进行对比

  文件的读写
     
     这里我们需要创建三个类：
         读文件类：readfile，这里需要将文件的文件名分割为考号+姓名
         写文件类：writefile
         需要进行评分的文件路径：这里我设置为E:\CSharp\CSharp\test4\TestWindows\students_answer
         
     写文件时利用filestream流的方法读取二进制文件。获取学生数量、分数、考试要求等。然后将这些信息转化为字节流存进数组中，通过writefile类将信息写入文件中。
     
     读文件时需要将数据各部分分开读取并储存，最后传递到Form中进行显示。
  
##结果展示   
   ![avatar](http://a3.qpic.cn/psb?/V11pI2Z53JzH8L/Qu6BynscuuaUKwiAWdKxM2Son6iq.CjSP0rlqC1j2rk!/b/dDYBAAAAAAAA&bo=6gNaAgAAAAADB5M!&rf=viewer_4)
   ![avatar](http://m.qpic.cn/psb?/V11pI2Z53JzH8L/iBX1jjtseNdfBXbrKsTeX.cE6FDshbmhwkiPkW54fpc!/b/dDcBAAAAAAAA&bo=6gNaAgAAAAADF4M!&rf=viewer_4)

  