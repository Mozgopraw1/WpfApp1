   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  EnglishAssistent��5   	   $��466.667��6"   $��746.569��63    � Icon$# united-kingdom-flag-16x16.ico��5	   	   .��5      � $��0,0,-291,-162q�6    � ColumnDefinitions 5   
   .+�5   
   �� -   5         ��Name$ Button1��5      $��Проверка��6"   $
��Left=�65   $��296,129,0,0q�6P   $	��Top=�6e   $	��142��6}   $��20��6�   �� 5   
   -   5        $ Button2��5      $��Потвердить��6"   $
��Left=�67   $��296,170,0,0q�6R   $	��Top=�6g   $	��142��6   $��20��6�   �� 5   
   -   5        $ Button3��5      $!��Добавить слово��6"   $
��Left=�6;   $��296,202,0,0q�6V   $	��Top=�6k   $	��142��6�   $��20��6�    J� RenderTransformOrigin$ -0.484,0.498&�6�   �� 5   
   -   5         ��Name$ TextBox1��5      $
��Left=�6$   $��61��6?   $��	7,129,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $%��Английское слово��6r   $	��Top=�6�   $	��273��6�   �� 5   
   -   5        $ TextBox2��5      $
��Left=�6$   $��55��6?   $��	7,202,0,0q�6K   $
 Wrap=�6^   $��Перевод��6r   $	��Top=�6�   $	��273��6�   �� 5   
   -   5         ��Name$ 
TextBlock1��5      $
��Left=�6(   $��	10,10,0,0q�6C   $
��Wrap=�6V   $	��Top=�6j   $��42��6�   $	��431��6�   �� 5   
   -   5        $ 
TextBlock2��5      $
��Left=�6(   $��	10,73,0,0q�6C   $
��Wrap=�6V   $	��Top=�6j   $ -0.107,-1.336&�6�   $	��431��6�   $��42��6�   �� 5   
   -   5        $ Da��5      $
��Да��6   $
��Left=�6*   $��	7,271,0,0q�6E   $	��Top=�6X   $	��120��6p   $��20��6�   �� 5   
   -	   5        $	 Net��5      $��Нет��6   $
��Left=�6,   $��160,271,0,0q�6G   $	��Top=�6\   $	��120��6t   $ 3.757,0.396&�6�   $��20��6�   �� 5   
   -
   5        $ SlovaSeg��5      $*��$Слова на повторения��6#   $
��Left=�6A   $��296,237,0,0q�6\   $	��Top=�6q   $	��142��6�   6�   �� 5   
   -   5         ��Name$ 	ChangeDay��5      	 �� Text$	 	ChangeDay��6&   $
��Left=�67   $��296,271,0,0q�6R   $	��Top=�6g   $	��142��6   4  .System.Windows.Automation.AutomationProperties
   Name$
 	ChangeDay��6�   $ 	0.5,0.545&�6�    �� ItemStringFormat$  ��6    � ContextMenu 5      �� 5      .@�5      �� -   5         ��Name$	 New��5      $	��New��6(   �� 5      -   5        $
 Day1��5      $��Day 1��6)   �� 5       -   5        $
 Day3��5       $��Day 3��6)   �� 5!      -   5        $
 Day7��5!      $��Day 7��6)   �� 5"      -   5        $ Day21��5"      $��Day 21��6*   �� 5#      -   5        $ Day50��5#      $��Day 50��6*   5$      �� 5%   
   -   5        $ NewText��5%      $
��Left=�6%   $��459,129,0,0q�6@   $
��Wrap=�6U   $	��Top=�6i   $	��134��6�   $��20��6�   �� 5&   
   -   5        $ Day1Text��5&      $
��Left=�6&   $��459,170,0,0q�6A   $
��Wrap=�6V   $	��Top=�6j   $	��134��6�   $��20��6�   �� 5'   
   -   5        $ Day3Text��5'      $
��Left=�6&   $��459,202,0,0q�6A   $
��Wrap=�6V   $	��Top=�6j   $��20��6�   $	��134��6�   �� 5(   
   -   5        $ Day7Text��5(      $
��Left=�6&   $��459,237,0,0q�6A   $
��Wrap=�6V   $	��Top=�6j   $��20��6�   $	��134��6�   �� 5)   
   -   5        $ 	Day21Text��5)      $
��Left=�6'   $��459,271,0,0q�6B   $
��Wrap=�6W   $	��Top=�6k   $��22��6�   $	��134��6�   �� 5*   
   -   5        $ 	Day50Text��5*      $
��Left=�6'   $��459,298,0,0q�6B   $
��Wrap=�6W   $	��Top=�6k   $��21��6�   $	��134��6�   5,      5-      