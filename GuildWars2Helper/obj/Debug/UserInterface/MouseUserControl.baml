   M S B A M L   `   `   `  ����K  GGuildWars2Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:GuildWars2Helper.UserInterfaceGuildWars2Helper.UserInterface  5      5    /GuildWars2Helper.UserInterface.MouseUserControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:GuildWars2Helper.UserInterface     5      .��5	      � ��5
   
   �� 5        �� EndPoint$
  .5,1&�6"    �� 
StartPoint$ .5, 0&�62   .��5      �  � Color$
 gray��6    � Offset$ 0Q�6,   � 5      $ white��6   $ 1Q�6-   5       � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��40 �6   �� 5      $��40 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   .+�5      �� -   5         ��Name$ StartMouseBtn��5      $��Start��6,   $��5q�6<   6G   �� 5      -   5        $ StopMouseBtn��5      $
��Stop��6+   $��5q�6:   6E   �� 5      -   5        $ TestBtn��5      $
��Test��6&   $��5q�65   6@   5      �� 5   
   $��1��6   $ 
Horizontal=�6"   .+�5       �� .��6   X:6   �� 5!      -   5         ��Name$ xLabel��5!      6&   �� 5"      .��6   Y:6   �� 5#      -   5        $ yLabel��5#      6&   5$      �� 5&   
   -   5        $ KeyDownCode��5&      $��2��6%   64   �� 5'   
   -   5        $ KeyPressCode��5'      $��3��6&   65   5(      5)      