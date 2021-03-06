# Content
+ [How to use](https://github.com/Touseefelahi/WpfFlatStyle#How-To-Use)
+ [Chrome Window](https://github.com/Touseefelahi/WpfFlatStyle#Chrome-Window)
+ [Sample](https://github.com/Touseefelahi/WpfFlatStyle#Sample)
+ [Button](https://github.com/Touseefelahi/WpfFlatStyle#button)
+ [Toggle Button](https://github.com/Touseefelahi/WpfFlatStyle#Toggle-button)
+ [CheckBox](https://github.com/Touseefelahi/WpfFlatStyle#checkbox)
+ [Text](https://github.com/Touseefelahi/WpfFlatStyle#text)
+ [Slider](https://github.com/Touseefelahi/WpfFlatStyle#slider)
+ [Layout](https://github.com/Touseefelahi/WpfFlatStyle#layout)
+ [Icons Style Sheet](https://github.com/Touseefelahi/WpfFlatStyle/blob/master/Style/Icons.xaml#StyleSheet)
+ [Icons Solid Style Sheet](https://github.com/Touseefelahi/WpfFlatStyle/blob/master/Style/IconsSolid.xaml#StyleSheet)

# How To Use
Add This In your App.xaml file

     <Application.Resources>
            <ResourceDictionary>
                <ResourceDictionary.MergedDictionaries>
                    <!-- Order is important -->
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/Colors.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/Fonts.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/BaseStyle.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/ButtonSoft.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/Icons.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/Button.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/ToolTip.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/ContextMenu.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/ListView.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/ListBox.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/ButtonIconBased.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/Text.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/GroupBox.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/Scroll.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/Datagrid.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/ComboBox.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/CheckBox.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/TabControl.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/ProgressBar.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/Slider.xaml" />
                    <ResourceDictionary Source="pack://application:,,,/FlatStyle;component/Style/WindowStyle.xaml" />
                </ResourceDictionary.MergedDictionaries>
            </ResourceDictionary>
        </Application.Resources>


# Chrome Window
 Add  these three lines in your window
 
        xmlns:flatStyle="clr-namespace:FlatStyle;assembly=FlatStyle"           
        Style="{StaticResource FlatWindow}"
        flatStyle:TitleBar.Value="30"
 As Shown below:
 
        <Window x:Class="FlatStyle.Sample.MainWindow"      
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"        
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"        
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"        
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"        
        xmlns:xctk="http://schemas.xceed.com/wpf/xaml/toolkit"        
        mc:Ignorable="d" 
        xmlns:flatStyle="clr-namespace:FlatStyle;assembly=FlatStyle"   
        Style="{StaticResource FlatWindow}"
        flatStyle:TitleBar.Value="30"
        Title="MainWindow" Height="450" Width="800">
        
# Sample
 
 Light Theme: 
![alt text](https://github.com/Touseefelahi/WpfFlatStyle/blob/master/Flatstyle.Style/BlueLightTheme.png " Light Theme")
 
Dark Theme: 
![alt text](https://github.com/Touseefelahi/WpfFlatStyle/blob/master/Flatstyle.Style/BlueDarkTheme.png " Dark Theme")

# Button
[Button Style Sheet](https://github.com/Touseefelahi/WpfFlatStyle/blob/master/Flatstyle.Style/Style/Button.xaml#StyleSheet)

[Icon Button Style Sheet](https://github.com/Touseefelahi/WpfFlatStyle/blob/master/Flatstyle.Style/Style/ButtonIconBased.xaml#StyleSheet)   
        
    <Button Content="Normal Button" />
    <Button Content="SecondaryButton" Style="{StaticResource SecondaryButton}" />
    <Button Style="{StaticResource IconButton}" Content="{StaticResource Fa-address-book}" />
    <Button Style="{StaticResource IconButton}"  Content="&#xf086;" />
    <Button Style="{StaticResource IconButton}"  Content="{StaticResource Fa-address-book}" />
    <Button Style="{StaticResource IconButton}"  Content="{StaticResource Fa-address-card}" />  
   
# Toggle Button
[Button Style Sheet](https://github.com/Touseefelahi/WpfFlatStyle/blob/master/Flatstyle.Style/Style/Button.xaml#StyleSheet)


    <ToggleButton flatStyle:IsCheckedText.Value="This Text Will Appear when its is checked"  flatStyle:IsUnCheckedText.Value="This Text Will Appear when its is unChecked"  />
    
     <ToggleButton flatStyle:IsCheckedText.Value="This Text Will Appear when its is checked"  flatStyle:IsUnCheckedText.Value="This Text Will Appear when its is unChecked" Style="{StaticResource SecondaryToggleButton}"  />
    <Button Style="{StaticResource IconButtonToggle}"  Content="{StaticResource Fa-address-card}" />              
 

# CheckBox
[Checkbox Style Sheet](https://github.com/Touseefelahi/WpfFlatStyle/blob/master/Flatstyle.Style/Style/CheckBox.xaml#StyleSheet)

     <CheckBox  Content="this g check" HorizontalAlignment="Left" />
     <CheckBox IsChecked="True"  Style="{StaticResource StatusLed}" />
     <CheckBox IsChecked="True"  Style="{StaticResource StatusLed}" flatStyle:BaseColor.Value="Green" />
     <CheckBox IsChecked="False" Style="{StaticResource StatusLed}" />
     <CheckBox IsChecked="False" Style="{StaticResource TickStatus}" />
     <CheckBox IsChecked="True"  Style="{StaticResource TickStatus}" />

# Text
[Text Style Sheet](https://github.com/Touseefelahi/WpfFlatStyle/blob/master/Flatstyle.Style/Style/Text.xaml#StyleSheet)

     <TextBlock Style="{StaticResource PrimaryText}" Text="This is Primary Text" />
     <TextBlock Style="{StaticResource PrimaryBackgroundText}" Text="This is PrimaryBackground Text" />
     <TextBlock Style="{StaticResource SecondaryText}" Text="This is Secondary Text" />
     <TextBlock Style="{StaticResource SecondaryBackgroundText}" Text="This is SecondaryBackground Text" />
     <TextBlock Style="{StaticResource ErrorText}" Text="This is Error Text" />
     <TextBlock Style="{StaticResource ErrorBackgroundText}" Text="This is ErrorBackground Text" />
    
     <TextBox Style="{StaticResource FieldBox}" flatStyle:FieldName.Value="Email" flatStyle:Placeholder.Value="Enter your email here"  Text="{Binding Email}" />
     <TextBox Style="{StaticResource FieldBoxVertical}" flatStyle:FieldName.Value="Email vertical" Text="{Binding Email}" />

     <TextBox Style="{StaticResource FieldBoxGetSet}" flatStyle:FieldName.Value="Email" Text="{Binding Email}"
              flatStyle:GetCommand.Value="{Binding GetCommand}" flatStyle:SetText.Value="Set set"
              flatStyle:SetCommand.Value="{Binding SetCommand}" />

     <TextBox Style="{StaticResource FieldBoxGetSetVertical}" flatStyle:FieldName.Value="Email vertical" Text="{Binding Email}"
              flatStyle:GetCommand.Value="{Binding GetCommand}" flatStyle:GetText.Value="Get Control" IsReadOnly="True"
                             flatStyle:SetCommand.Value="{Binding SetCommand}" />


# Slider
    <Slider Style="{StaticResource NumericUpDown}" />

# Layout
     <flatStyle:TilePanel Color="{DynamicResource PrimaryBrush}" Margin="10" Title="Super Tile" >
            <StackPanel HorizontalAlignment="Center">
                <TextBlock Text="This"/>
                <TextBlock Text="is"/>
                <TextBlock Text="Spartaaa"/>
            </StackPanel>
     </flatStyle:TilePanel>