namespace WpfSimpleMessageBox
{
    public static class MessageDialog
    {
        public static void ShowSuccess(string message, string title = "成功", string buttonName = "确定")
        {
            CustomMessageBox.Show(title, message, buttonName, "", MessageIcons.Success);
        }

        public static void ShowInfo(string message, string title = "提示", string buttonName = "确定")
        {
            CustomMessageBox.Show(title, message, buttonName, "", MessageIcons.Info);
        }

        public static bool? ShowConfirm(string message, string title = "请确认",
            string confirm = "确定", string cancel = "取消")
        {
            return CustomMessageBox.Show(title, message, confirm, cancel, MessageIcons.Warning);
        }

        public static void ShowError(string message, string title = "错误", string buttonName = "关闭")
        {
            CustomMessageBox.Show(title, message, buttonName, "", MessageIcons.Error);
        }
    }
}
