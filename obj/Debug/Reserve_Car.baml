   M S B A M L   `   `   `  ����L  HCarReservationApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CarReservationAppCarReservationApp  5   	   #    CarReservationApp.Reserve_Car   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CarReservationApp     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5          � Title$  CAR RESERVATION��5
   	   $	��450��6!   $	��800��6.   ��5      �� 5   
    �� ImageSource$ Images/Cars.jpg��6   .��5      � .+�5   
   � $
��Left=�6   $	��419��6*   $	��Top=�67   $	��180��6O   �� 5   
    �� Orientation$ 
Horizontal=�6   $	��Top=�6.   $
��83.8��6F   $��	0,0,612,0q�6T   �� 5   
   $ 
Horizontal=�6   $	��Top=�6.   $
��83.8��6F   $��
0,83,612,0q�6T   �� 5   
   $ 
Horizontal=�6   $	��Top=�6.   $
��83.8��6F   $��0,167,612,0q�6T   �� 5   
   $ 
Horizontal=�6   $	��Top=�6.   $
��83.8��6F   $��0,251,612,0q�6T   �� 5   
   $ 
Horizontal=�6   $	��Top=�6.   $
��83.8��6F   $��0,335,612,0q�6T   �� 5   
   $��1q�6   $��0��6%    �� CornerRadius$ 
0,20,20,20��62   
���   �
���OO/�$��42,23,53,54q�6{   ._�5      � $��	0,0,0,310q�6   
��� ���.+�5      �� $��RESERVE CAR��6   $
��Left=�6.   $	��Top=�6I   �� 5      $��Car Type and Name��6   $��12(�64   
��� ���$
��Left=�6V   $	��Top=�6q   $��14,59,0,-55q�6�   �� 5      $��Pick-Up Location��6   $��12(�63   
��� ���$
��Left=�6U   $	��Top=�6p   $��164,59,0,-55q�6�   �� 5      $��Transmission��6   $��12(�6/   
��� ���$
��Left=�6Q   $	��Top=�6l   $��306,59,0,-55q�6�   �� 5      $��Price��6   $��12(�6(   
��� ���$
��Left=�6J   $	��Top=�6e   $��434,59,0,-55q�6}   5      5       � 5!   
   .+�5#      � $��495,72,104,50q�6   �� 5$      -   5        $��Reserve the Car��5$      ���	#FF405CDA$
��Left=�6F   $	��Top=�6a   $	��138��6y   $��252,375,0,0q�6�   $��34��6�   �� 5&      -   5        $��TBx_ChooseCar��5&      
���   �
�������$
��Left=�6Q   $
��Auto��6l   $��
56,119,0,0q�6z    �� TextWrapping$
 Wrap=�6�   $��TextBox��6�   $	��Top=�6�   $	��116��6�   �� 5'      -   5        $��TBx_PickLoc��5'      
���   �
�������$
��Left=�6O   $
��Auto��6j   $
 Wrap=�6x   $��TextBox��6�   $	��Top=�6�   $	��100��6�   $��210,119,0,0q�6�   �� 5(      -   5        $��TBx_TransmissionType��5(      
���   �
�������$
��Left=�6X   $
��Auto��6s   $
 Wrap=�6�   $��TextBox��6�   $	��Top=�6�   $��65��6�   $��356,119,0,0q�6�   �� 5)      -   5        $��	TBx_Price��5)      
���   �
�������$
��Left=�6M   $
��Auto��6h   $
 Wrap=�6v   $��TextBox��6�   $	��Top=�6�   $��66��6�   $��478,119,0,0q�6�   5,      51      52      