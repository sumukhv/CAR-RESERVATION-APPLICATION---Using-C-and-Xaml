   M S B A M L   `   `   `  ����L  HCarReservationApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CarReservationAppCarReservationApp  5   	   "    CarReservationApp.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CarReservationApp     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5          � 
ResizeMode$  NoResize=�5   	    � Title$ CAR RESERVATION��5
   	   $	��450��6!   $	��800��6.   ��5      �� 5   
    �� ImageSource$ Images/Cars.jpg��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��25* �6   �� 5      $
��371* �6   .+�5   
   � $��1��6   $
��Left=�6   $	��367��6:   $��
168,10,0,0q�6G   $	��Top=�6[   $	��346��6s   .+�5      �� ���	#FFF4F4F5$
��Left=�6)   $	��367��6D   
���   �$	��Top=�6`   $	��346��6x   �� 5      $
��Left=�6   $��56��64   $	��Top=�6@   $	��346��6X   .+�5      �� $��LOGIN��6   $��Center=�6(   $��Bottom=�6E   $
��Bold"�6`   $��120,10q�6r   $��18(�6�   5      �� 5      $
��Left=�6   $	��176��64   $��Bottom=�6A   $	��346��6\   $��	0,0,0,102q�6h   .+�5      �� $��Email��6   $��6,5,50,0q�6(   �� 5      -   5        $��	Txt_Email��5      $��23��6+    �� TextWrapping$
 Wrap=�67   $�� ��6K    J� Opacity$	 0.3Q�6T   $��	10,4,50,5q�6�   $��1q�6�   �� 5       $��Password��6   $��6,0,50,0q�6+   G� 5!      -   5        $��TBx_Password��5!      $��23��62   $	 0.3Q�6?   $��	10,4,50,0q�6N   $��1q�6a   5#      �� 5$      $
��Left=�6   $��49��64   $��Bottom=�6@   $	��346��6[   $��0,0,0,53q�6g   .+�5&      �� -   5        $��	Btn_Login��5&      $��Login��6*   $��Center=�6:   $��Center=�6W   $��60,10,60,10q�6r   ���	#FF405CDA6�   5(      �� 5)      $
��Left=�6   $��53��64   $��Bottom=�6@   $	��346��6[   .+�5+      �� -   5        $��label1��5+   6   $��25��6   $��0,10,0,0q�6$   $��Center=�6D   $	��Top=�6a   .��5,      �� -   5        .�5,   8   Don't have an account?6P   5-      50      54      56      57      