---
layout: post
title:  "Layout 入门 第一篇"
date:   2018-03-27 21:31:43 +0800
categories: xamarin forms Layout  
---   
本来打算先写```C#```的一些基础知识，但是网上有好多比较基础的文章还是可以直接看的，所以我就先忽略```C#```的基础文章，还是直接写一些```Xamarin Forms```的文章吧。      
其实在上上周左右吧，我就发现```Xamarin``` 相关的文档都已经迁移到微软官网了，并且还有了机器翻译的文档[官方文档](https://docs.microsoft.com/zh-cn/xamarin/xamarin-forms/)  ,好了话不多说，还是来学一下吧。    

在```Xamarin Forms```中有5种布局，[官方文档](https://docs.microsoft.com/zh-cn/xamarin/xamarin-forms/user-interface/layouts/)   
![]({{site.url}}/images/layout/layouts-sml.png)    
我们就一个一个来学习一下


# StackLayout
       
```StackLayout```(栈布局)，类似安卓里面线性布局，定位由视图添加到的布局和视图的布局选项的顺序确定。    

![]({{site.url}}/images/layout/stacklayout.png)     
如图所示，就是依次排列下来，默认情况下，栈布局添加的子视图有6px的边距，当然可以设置```Spacing```属性来调整。

说几个常用的属性```LayoutOptions```这个属性可以设置的值有
> * CenterAndExpand 在视图中间扩充占用足够的大小
> * EndAndExpand  在视图底部扩充占用足够的大小
> * StartAndExpand 在视图上面占用足够的大小      

当然还有```Start```, ```Center```等属性。     

```Orientation``` 可以设置子视图的方向, 有两个可选值包括```Vertical``` 和 ```Horizontal```.     

```VerticalOptions``` 可以设置子视图在横轴上的排列方式，可选值类似```LayoutOptions```的可选值。

举个例子，例
![]({{site.url}}/images/layout/sv.png)   

```C#
 <StackLayout Orientation="Vertical" VerticalOptions="Start" 
                 HorizontalOptions="Center">
        <BoxView HeightRequest="100" WidthRequest="100" 
                 BackgroundColor="Red" />
    </StackLayout>
```   
 
其中子视图的方向是 纵向， 纵向排列从头开始，横向排列在中间，所以小红块在最上的中间。 
![]({{site.url}}/images/layout/sv2.png)    
小蓝块在小红块的下面排列   
这个布局还是比较简单，很容易理解。
