   M S B A M L   `   `   `  ����R  NVMAT_Grid_Targets.esapi, Version=0.1.0.1, Culture=neutral, PublicKeyToken=null5clr-namespace:VMAT_Grid_TargetsVMAT_Grid_Targets  5   	   #    VMAT_Grid_Targets.InitialMenu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:VMAT_Grid_Targets     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Select Target��5	   	   $	��250��6   $	��600��6,    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
StartPoint �� EndPoint � Color	 � Offset
 �� 
TargetType ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  '��       '�� �    �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      $ 0.5, 0&�6*   $ 0.5, 1&�6>   .��5      � $ #606060��6'   $		 0.3Q�67   � 5      $ Black��6'   $	 1Q�65   5      5      �� 5       � ��
 �����6+   �� 5       � ��$ 20(�6)   �� 5       � ��$ DemiBold"�6+   �� 5       � ��$ ./#Segoe UI)�6+   �� 5       � �� 5      �� 5      "
 ��6&   .R�5      �� $ Button_border��6!   #��z��68   
���   �$��1q�6v   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5        �@J�IsMouseOver . . �5!   "   �� $ Button_border��6)    � ��
 �����6[   5"      5$      5&      5'      �� 5)   
   " ��6   .�5*      ��  � ��
 �   �6+   �� 5+       � ��$ 20(�6)   �� 5,       � ��$
 Bold"�6+   5-      5.      .��50      �� ���#922247
�������$��10q�65   ._�51   
   �  � ColumnDefinitions 52      �� 53      $��* �6#   �� 54      $��* �6#    � RowDefinitions 56      �� 57      $
��0.6* �6    �� 58      $��* �6    .+�5;      �� -   5        $��PTV_Structure��5;   1   $��0��6   $��0��6$   $��Select Target��6F   $
��Left=�6^   $��Center=�6y   $��80,0,0,0q�6�   6�   �� 5=      -   5        $��structure_selection��5=   4   $��1��6   $��0��6'   $	��230��6O   $��30��6[   $��Center=�6g   $��Center=�5>      $
��Bold"�6;   $��16(�6M   ���#D3D3D35?   G   �� 5B      -   5        $��Calculate_Plan��5B   2   $��1��6   $��1��6%   $��75��6H   $	��200��6T   $��Center=�5C      $��
0, 0, 0, 0q�62    5D      ��%_   '��       �� 5E      " ��6   .�5F      ��  �@��CornerRadius$ 10��69   5G      5H      ��5I      �� 5J      Calculate Spheres63   5L      �� 5M      -   5        $��loyola_medicine��5M   y   $��0��6   $��1��6$   $	��100��61   $	��200��6>   $��Center=�6J   $��
0, 0, 0, 0q�6e   $Q��Kpack://application:,,,/VMAT_Grid_Targets.esapi;component/LoyolaMedicine.png��5N      6k   5O      5P      5Q      