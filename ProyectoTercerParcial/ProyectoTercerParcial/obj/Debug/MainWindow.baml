   M S B A M L   `   `   `  ����P  LProyectoTercerParcial, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ProyectoTercerParcialProyectoTercerParcial  5   	   &     ProyectoTercerParcial.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ProyectoTercerParcial     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5         �Name$ 
grdgeneral��5	      .+�5
   
   �� -   5         ��Name$ cbSEPE��5
      $
��Left=�6#   $��
480,40,0,0q�6>   $	��Top=�6R   $	��120��6j   .@�5      �� .��6   Serie6"   �� 5      .��6   
Pelicula6%   5      �� 5   
   $
��Left=�6   $��
480,10,0,0q�6/   $
��Wrap=�6C   $��Agregar��6W   $	��Top=�6f   �� 5   
   -   5         ��Name$ 
btnaceptar��5      $��Aceptar��6%   $
��Left=�67   $��
616,40,0,0q�6R   $	��Top=�6f   $��75��6~   6�   � 5   
   -   5        $ 
grdagregar��5      $
��Left=�6#   $	��281��6>   $��278,105,0,0q�6K   $	��Top=�6`   $	��506��6x   �� 5   
   -   5         ��Name$ 	listdatos��5      $
��Left=�6&   $	��400��6A   $��	10,10,0,0q�6N   $	��Top=�6a   $	��242��6y    �� View 5      �� 5      .P�5      �� $��Titulo��6M    �� Width$	 170��6]    �� DisplayMemberBinding 6%   �� *Titulo+6k   �� 5      $
��Año��6J   $ 70��6W    6%   �� *Año+6d   5      5      �� 5   
   -   5        $ btnasc��5      $	��↑��6!   $
��Left=�6-   $��
267,10,0,0q�6H   $	��Top=�6\   $��75��6t   6   �� 5   
   -   5        $ btndes1��5      $	��↓��6"   $
��Left=�6.   $��
267,40,0,0q�6I   $	��Top=�6]   $��75��6u   6�   �� 5   
   -   5        $ btnaz��5      $	��A-Z��6    $
��Left=�6.   $��
358,10,0,0q�6I   $	��Top=�6]   $��75��6u   6�   �� 5   
   -	   5        $ btnza��5      $	��Z-A��6    $
��Left=�6.   $��
358,40,0,0q�6I   $	��Top=�6]   $��75��6u   6�   �� 5   
   -
   5        $ 	btneditar��5   &   $y�Hidden=�6   $��Editar��6:   $
��Left=�6K   $��278,391,0,0q�6f   $	��Top=�6{   $��75��6�   6�   �� 5   
   -   5        $ btneliminar��5   &   $y�Hidden=�6   $��Eliminar��6<   $
��Left=�6O   $��480,391,0,0q�6j   $	��Top=�6   $��75��6�   6�   �� 5    
   -   5        $ btncancelar1��5    &   $y�Hidden=�6   $��Cancelar��6=   $
��Left=�6P   $��580,391,0,0q�6k   $	��Top=�6�   $��75��6�   6�   �� 5!   
   -   5        $ btnaceptar1��5!   &   $y�Hidden=�6   $��Aceptar��6<   $
��Left=�6N   $��379,391,0,0q�6i   $	��Top=�6~   $��75��6�   6�   5#      5$      