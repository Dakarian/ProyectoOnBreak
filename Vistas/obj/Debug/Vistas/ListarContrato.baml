   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   A =Vistas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistasVistas 5
   	      Vistas.ListarContrato   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	    localclr-namespace:Vistas  5
   	     � Title$  ListarContrato��5   	   $��492.709��6    $��1037.399��61    � WindowStartupLocation$ CenterScreen=�6B    � 
ResizeMode$ NoResize=�6g   .��5      � $��0,0,4,0q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dg_contrato��5      $
��Left=�6(   $	��182��6C   $��	10,10,0,0q�6P   $	��Top=�6c   $	��970��6{   �� 5   
   -   5         ��Name$ label��5      $��Filtro por contrato:��6   $
��Left=�6>   $��
11,211,0,0q�6Y   $	��Top=�6m   $	��109��6�   �� 5   
   -   5         ��Name$ txt_filtrocon��5      $
��Left=�6)   $��23��6D   $��125,211,0,0q�6P    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��120��6�   6�   �� 5   
   -   5         ��Name$ 
btn_volver��5      $��Volver��6%   $
��Left=�66   $��323,425,0,0q�6Q   $	��Top=�6f   $��75��6~   6�   �� 5   
   -   5        $ label1��5      $��Filtro por evento:��6    $
��Left=�6=   $��
19,242,0,0q�6X   $	��Top=�6l   $	��101��6�   �� 5   
   -   5        $ txt_filtroev��5      $
��Left=�6(   $��23��6C   $��125,242,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   6�   �� 5   
   -   5        $ label2��5      $��
Babyshower��6    $
��Left=�65   $��267,242,0,0q�6P   $	��Top=�6e   ���	#FFACA5A5$��75��6�   �� 5   
   -   5        $ label3��5      $��Galas��6    $
��Left=�60   $��267,273,0,0q�6K   $	��Top=�6`   ���	#FFACA5A5$��39��6�   �� 5   
   -	   5        $ label4��5      $��Cumpleaños��6    $
��Left=�65   $��267,304,0,0q�6P   $	��Top=�6e   ���	#FFACA5A5$��77��6�   �� 5   
   -
   5        $ label5��5      $��Bodas��6    $
��Left=�60   $��267,335,0,0q�6K   $	��Top=�6`   ���	#FFACA5A5$��43��6�   !   MahApps.Metro.Controls.Tile  5   
   -   5          Name$ btn_actualizargrid��5      $
��Auto��64   $��990,10,10,428q�6B   $
��Auto��6Y   .��5      �� $3��-/Vistas;component/Iconos/Data-Synchronize.png��6   6M   5        5   
   -   5        $ btn_vigencia��5      $
��Auto��6.   $��267,211,735,227q�6<   $
��Auto��6U   .��5      �� $0��*/Vistas;component/Iconos/Align-Justify.png��6   6J   5      5      5       