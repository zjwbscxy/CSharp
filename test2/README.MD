## CSharp
# 第二次作业概述
- 老师您好，我是周嘉伟

     这一次的作业较为简单，并且老师也给出了参考，再加上网上搜索了很多资料后，完成了这一次的作业。同时在完成作业的过程中
也很感谢邓丞君同学、刘一达同学的帮助。
     
- 本次作业的目标
     
     1.使用Open XML SDK方法解析Word文件，提取出Word文件中的所有文字。文字按段落分组。使用WordprocessingDocument类作
为实验项目的主要类。
     
     2.把方法封装到自定义类中。
     
- 实现过程
   
   1.将目标文件地址存储到字符串fileName
   
   2.从WordprocessingDocument类中创建一个新的实例myDocument
   
   3.创建一个Body类word
   
   4.遍历Body类Elements的对象
   
   5.将对象中存储的正文打印
   
   6.最后在结尾通过Console.ReadKey()语句设置为按下任意按键退出