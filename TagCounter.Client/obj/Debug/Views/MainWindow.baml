   M S B A M L   `   `   `  ����L  HTagCounter.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TagCounter.ClientTagCounter.Client  5      "    TagCounter.Client.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:TagCounter.Client     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          � Title$  
TagCounter��5      $	��800��5	      $	��450��5
      $	��400��5      $	��200��5       � DataContext 5      ��    ViewModelLocator �� Source# [   �� Path$ MainViewModel�.��5      ]� .+�5   
   � $��Bottom=�6   .+�5      �� $	��100��5      $��10q�5      $��5q�5      $
��Left=�5      $��
Обзор��5      ��5      �� *Open+5      �� 5      $��5q�5      $��Center=�5       �� Orientation$ 
Horizontal=�5      .+�5       �� $	��100��5!      $��5q�5"      $��5q�5#      $��Start��5%      ��5$      �� *
StartCount+5%      �� 5'      $	��100��5(      $��5q�5)      $��5q�5*      $
��Left=�5+      $
��Stop��5-      ��5,      �� *	StopCount+5-      5/      50      � 52   
    � ColumnDefinitions 53      �� 54      �� 55      .+�58      �� $��5q�59      
���   �$��1q�5;      ._�5=      �� -   5         ��Name$ lbLogEvents��5>      $��14(�5?      ��5@      �� *	LogEvents+5A      &   System.Windows.Controls.DataGrid  5C      -   5          Name$ 	dgResults��5D      $��1��5E      $��5q�5F      $��Center=�5G         AlternatingRowBackground
 �����	   AutoGenerateColumns	 .  
���   �$��14(�5K      
   HorizontalGridLinesBrush

 �   �   
IsReadOnly .    RowBackground
 �������5N      �� *	Results+   Columns 5Q      0  *System.Windows.Controls.DataGridTextColumn  5R      ,  &System.Windows.Controls.DataGridColumn   MinWidth$ 80Q�5S         Header$% Количество Тегов��5U      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5T      �� $ TagCount�5U      5  /System.Windows.Controls.DataGridHyperlinkColumn  5W      $	 200Q�5X      $ 
Адрес��5Z       5Y      �� $ UrlLink�5Z      5]      5^      5_      5`      