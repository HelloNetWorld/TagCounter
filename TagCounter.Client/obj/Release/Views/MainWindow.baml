   M S B A M L   `   `   `  ���� L  HTagCounter.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TagCounter.ClientTagCounter.Client  "    TagCounter.Client.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     1localclr-namespace:TagCounter.Client     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     � Title$  
TagCounter��$	��800��$	��450��$	��400��$	��200�� � DataContext ��    ViewModelLocator �� Source# [   �� Path$ MainViewModel�.��]� .+�� $��Bottom=�.+��� $	��100��$��10q�$��5q�$
��Left=�$��
Обзор������ *Open+�� $��5q�$��Center=� �� Orientation$ 
Horizontal=�.+��� $	��100��$��5q�$��5q�$��Start������ *
StartCount+�� $	��100��$��5q�$��5q�$
��Left=�$
��Stop������ *	StopCount+�  � ColumnDefinitions �� �� .+��� $��5q�
���   �$��1q�._��� -    ��Name$ lbLogEvents��$��14(����� *	LogEvents+&   System.Windows.Controls.DataGrid  -     Name$ 	dgResults��$��1��$��5q�$��Center=�   AlternatingRowBackground
 �����	   AutoGenerateColumns	 .  
���   �$��14(�
   HorizontalGridLinesBrush

 �   �   
IsReadOnly .    RowBackground
 ��������� *	Results+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   MinWidth$ 80Q�   Header$% Количество Тегов��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� $ TagCount�5  /System.Windows.Controls.DataGridHyperlinkColumn  $	 200Q�$ 
Адрес�� �� $ UrlLink�