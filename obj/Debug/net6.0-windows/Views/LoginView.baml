   M S B A M L   `   `   `  ����>  :Zoo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Zoo.Views	Zoo.Views  5   	   1clr-namespace:Zoo.View_ModelsZoo.View_Models  5   	       Zoo.Views.LoginView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Zoo.Views     5   	   4
viewmodelsclr-namespace:Zoo.View_Models     5   	     � Title$	  Zoo��5	   	   $	��600��6   $	��900��6"    � DataContext 5
      #   Zoo.View_Models.MainViewModel  5   
   .��5      � -   5         �Name$ MainGrid��5      $	��580��6   $	��900��6*   .+�5   
   � $	��580��6   $	��900��6   ��5      �� 5       �� ImageSource$ /Pictures/zoo5.jpg��6    � RowDefinitions 5   
   �� 5      6   �� 5      6   .+�5   
   � -   5        $ descriptionGrid��5      $��0��6(   $	��840��65   $��30,30,30,10q�6A    � ColumnDefinitions 5      �� 5      $
��280* �6#   5      �� 5      $	��39* �6#   61   �� 5      $
��241* �6#   �� 5      $
��280* �6#   62    5      �� 5       $��50 �6    5!      �� 5"      6"   .+�5$      �� $��1��6   $��10,10,10,10q�6#    �� CornerRadius$ 25��68   $��2q�6J   ���	#FF000000$��0��6v   ��5%      �� 5&       j� Stretch$
 Fill=�6!   $ /Pictures/Zoo2.jpg��60   5)      �� 5*      $��1��6   $��10,10,10,10q�6#   $ 25��68   $��2q�6J   ���	#FF000000$��1��6v   $��2��6�   ��5+      �� 5,      $
 Fill=�6!   $ /Pictures/Zoo8.jpg��60   5/      �� 50      $��1��6   $��10,10,10,10q�6#   $ 25��68   $��2q�6J   ���	#FF000000$��3��6v   ��51      �� 52      $
 Fill=�6!   $ /Pictures/Zoo3.jpg��60   55      �� 57      $
��Left=�6   $��NoWrap=�64   $��	Sofia Zoo��6J   $��Center=�6[   $��38(�6v   $��1��6�   $	��296��6�    �� TextAlignment$ Center=�6�   $��Sitka Heading)�6�   ���	#FFFF8000$��3��6�   59      �� 5:   
   -   5        	 ��Name$	 LoginBorder��5:      $��1��6(   $��500,30,50,30q�65   $ 25��6K   ���	#FF1BAD82
���   �$��5q�6�   ._�5;      �� .+�5<      �� $
��Wrap=�6   $��Username��60   $
 Left=�6@   $��20,10,232,15q�6U   $��18(�6k   �� 5=      -   5        
 ��Name$
 UserNameInput��5=       �� TextWrapping$
 Wrap=�6O   $	��300��6c   $��30��6o   
�������$��18(�6�   $��0,-5,0,0q�6�   ��65   �� *
Username+6�   �� 5>      $
��Wrap=�6!   $��Password��65   $
 Left=�6F   $��20,20,232,15q�6[   $��18(�6q   G� 5?      -   5        $��0,-5,0,0q�5?   "   $��30��64   $	��300��6@   $��18(�6L   6Z   �� 5@      $��Вход��6   $��30��6(   $	��100��64   $��Right=�6@   $��	0,15,50,0q�6\   $
��Menu��6�   ��6o   �� *UpdateViewCommand+6�   5A      5B      5D      �� 5E   
   ��6   �� *SelectedViewModel+5G      5H      