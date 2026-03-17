using System.Collections.ObjectModel;

namespace W26Week10IntroToMaui;

public partial class ToDoPage : ContentPage
{
	ObservableCollection<string> tasks = new ObservableCollection<string>();

	public ToDoPage()
	{
		InitializeComponent();
		lvTasks.ItemsSource = tasks;
	}

    private void OnAddTaskClicked(object sender, EventArgs e)
    {
		if (!string.IsNullOrWhiteSpace(txtTask.Text))
		{
			tasks.Add(txtTask.Text);
			txtTask.Text = string.Empty;
			txtTask.Focus();
		}
    }

    private void OnDeleteTaskSwiped(object sender, EventArgs e)
    {
        if (sender is SwipeItem swipeItem && swipeItem.BindingContext is string task)
        {
            tasks.Remove(task);
        }
    }
}