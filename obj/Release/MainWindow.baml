   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp1       � Title$  EnglishAssistent��$��466.667��$��746.569�� � Icon$# united-kingdom-flag-16x16.ico��.��� $��0,0,-291,-162q� � ColumnDefinitions .+��� -    ��Name$ Button1��$��Проверка��$
��Left=�$��296,129,0,0q�$	��Top=�$	��142��$��20���� -   $ Button2��$��Потвердить��$
��Left=�$��296,170,0,0q�$	��Top=�$	��142��$��20���� -   $ Button3��$!��Добавить слово��$
��Left=�$��296,202,0,0q�$	��Top=�$	��142��$��20�� J� RenderTransformOrigin$ -0.484,0.498&��� -    ��Name$ TextBox1��$
��Left=�$��61��$��	7,129,0,0q� �� TextWrapping$
 Wrap=�$%��Английское слово��$	��Top=�$	��273���� -   $ TextBox2��$
��Left=�$��55��$��	7,202,0,0q�$
 Wrap=�$��Перевод��$	��Top=�$	��273���� -    ��Name$ 
TextBlock1��$
��Left=�$��	10,10,0,0q�$
��Wrap=�$	��Top=�$��42��$	��431���� -   $ 
TextBlock2��$
��Left=�$��	10,73,0,0q�$
��Wrap=�$	��Top=�$ -0.107,-1.336&�$	��431��$��42���� -   $ Da��$
��Да��$
��Left=�$��	7,271,0,0q�$	��Top=�$	��120��$��20���� -	   $	 Net��$��Нет��$
��Left=�$��160,271,0,0q�$	��Top=�$	��120��$ 3.757,0.396&�$��20���� -
   $ SlovaSeg��$*��$Слова на повторения��$
��Left=�$��296,237,0,0q�$	��Top=�$	��142���� -    ��Name$ 	ChangeDay��	 �� Text$	 	ChangeDay��$
��Left=�$��296,271,0,0q�$	��Top=�$	��142��4  .System.Windows.Automation.AutomationProperties
   Name$
 	ChangeDay��$ 	0.5,0.545&� �� ItemStringFormat$  �� � ContextMenu �� .@��� -    ��Name$	 New��$	��New���� -   $
 Day1��$��Day 1���� -   $
 Day3��$��Day 3���� -   $
 Day7��$��Day 7���� -   $ Day21��$��Day 21���� -   $ Day50��$��Day 50���� -   $ NewText��$
��Left=�$��459,129,0,0q�$
��Wrap=�$	��Top=�$	��134��$��20���� -   $ Day1Text��$
��Left=�$��459,170,0,0q�$
��Wrap=�$	��Top=�$	��134��$��20���� -   $ Day3Text��$
��Left=�$��459,202,0,0q�$
��Wrap=�$	��Top=�$��20��$	��134���� -   $ Day7Text��$
��Left=�$��459,237,0,0q�$
��Wrap=�$	��Top=�$��20��$	��134���� -   $ 	Day21Text��$
��Left=�$��459,271,0,0q�$
��Wrap=�$	��Top=�$��22��$	��134���� -   $ 	Day50Text��$
��Left=�$��459,298,0,0q�$
��Wrap=�$	��Top=�$��21��$	��134��