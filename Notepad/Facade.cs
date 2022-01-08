using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notepad;

namespace Notepad
{
    class Facade
    {
        private static Facade INSTANCE = new Facade();

        public Language_ob L_ob = new Language_ob();
        private IChangeLanguage Language;


        public void setFacade(IChangeLanguage language)
        {
            INSTANCE.Language = language;
            INSTANCE.L_ob = INSTANCE.Language.changeLanguage(this.L_ob);
        }

        public Facade()
        {
            this.Language = new Chinese();
        }

        public static Facade getInstance()
        {
            return INSTANCE;
        }

    }

    class Language_ob
    {
        public string fileToolStripMenuItem;
        public string newToolStripMenuItem;
        public string openToolStripMenuItem;
        public string saveToolStripMenuItem;
        public string saveAsToolStripMenuItem;
        public string printToolStripMenuItem;
        public string exitToolStripMenuItem;

        public string editToolStripMenuItem;
        public string undoToolStripMenuItem;
        public string cutToolStripMenuItem;
        public string copyToolStripMenuItem;
        public string colorToolStripMenuItem;
        public string pasteToolStripMenuItem;
        public string deleteToolStripMenuItem;
        public string gotoToolStripMenuItem;
        public string findToolStripMenuItem;
        public string replaceToolStripMenuItem;
        public string selectAllToolStripMenuItem;
        public string timeDateToolStripMenuItem;

        public string formatToolStripMenuItem;
        public string wordWToolStripMenuItem;
        public string fontToolStripMenuItem;

        public string viewToolStripMenuItem;
        public string statusBarToolStripMenuItem;

        public string helpToolStripMenuItem;
        public string aboutToolStripMenuItem;

        public string languageToolStripMenuItem;

        public Language_ob() 
        {
        }
    }

    interface IChangeLanguage
    {
        Language_ob changeLanguage(Language_ob ob);
    }

    class Chinese : IChangeLanguage 
    {
        public Language_ob changeLanguage(Language_ob ob) 
        {
                ob.fileToolStripMenuItem = "文件";
                ob.newToolStripMenuItem = "新的";
                ob.openToolStripMenuItem = "打开";
                ob.saveToolStripMenuItem = "保存";
                ob.saveAsToolStripMenuItem = "另存为";
                ob.printToolStripMenuItem = "打印";
                ob.exitToolStripMenuItem = "出口";

                ob.editToolStripMenuItem = "编辑";
                ob.undoToolStripMenuItem = "撤销";
                ob.cutToolStripMenuItem = "切";
                ob.copyToolStripMenuItem = "复制";
                ob.colorToolStripMenuItem = "颜色";
                ob.pasteToolStripMenuItem = "粘贴";
                ob.deleteToolStripMenuItem = "删除";
                ob.gotoToolStripMenuItem = "去";
                ob.findToolStripMenuItem = "寻找";
                ob.replaceToolStripMenuItem = "代替";
                ob.selectAllToolStripMenuItem = "全选";
                ob.timeDateToolStripMenuItem = "时间";

                ob.formatToolStripMenuItem = "格式";
                ob.wordWToolStripMenuItem = "全文";
                ob.fontToolStripMenuItem = "字体";

                ob.viewToolStripMenuItem = "看法";
                ob.statusBarToolStripMenuItem = "状态栏";

                ob.helpToolStripMenuItem = "帮助";
                ob.aboutToolStripMenuItem = "关于";

                ob.languageToolStripMenuItem = "语";

            return ob;
        }
    }
    class VietNamese : IChangeLanguage
    {
        public Language_ob changeLanguage(Language_ob ob)
        {
                ob.fileToolStripMenuItem = "Tệp";
                ob.newToolStripMenuItem = "Mới";
                ob.openToolStripMenuItem = "Mở";
                ob.saveToolStripMenuItem = "Lưu";
                ob.saveAsToolStripMenuItem = "Lưu là";
                ob.printToolStripMenuItem = "In";
                ob.exitToolStripMenuItem = "Thoát";

                ob.editToolStripMenuItem = "Chỉnh sửa";
                ob.undoToolStripMenuItem = "Quay lại";
                ob.cutToolStripMenuItem = "Cắt";
                ob.copyToolStripMenuItem = "Sao chép";
                ob.colorToolStripMenuItem = "Màu sắc";
                ob.pasteToolStripMenuItem = "Dán";
                ob.deleteToolStripMenuItem = "Xoá";
                ob.gotoToolStripMenuItem = "Đi đến";
                ob.findToolStripMenuItem = "Tìm kiếm";
                ob.replaceToolStripMenuItem = "Thay thế";
                ob.selectAllToolStripMenuItem = "Chọn tất cả";
                ob.timeDateToolStripMenuItem = "Ngày giờ";

                ob.formatToolStripMenuItem = "Định dạng";
                ob.wordWToolStripMenuItem = "Toàn bộ văn bản";
                ob.fontToolStripMenuItem = "Kiểu chữ";

                ob.viewToolStripMenuItem = "Xem";
                ob.statusBarToolStripMenuItem = "Thanh trạng thái";

                ob.helpToolStripMenuItem = "Giúp";
                ob.aboutToolStripMenuItem = "Về";

                ob.languageToolStripMenuItem = "Ngôn ngữ";
            return ob;
        }
    }

    class Japan : IChangeLanguage
    {
        public Language_ob changeLanguage(Language_ob ob)
        {
            ob.fileToolStripMenuItem = "ファイル";
            ob.openToolStripMenuItem = "開ける";
            ob.saveToolStripMenuItem = "保存する";
            ob.saveAsToolStripMenuItem = "名前を付けて保存";
            ob.printToolStripMenuItem = "印刷";
            ob.exitToolStripMenuItem = "出口";

            ob.editToolStripMenuItem = "編集";
            ob.undoToolStripMenuItem = "元に戻す";
            ob.cutToolStripMenuItem = "切る";
            ob.copyToolStripMenuItem = "コピー";
            ob.colorToolStripMenuItem = "色";
            ob.pasteToolStripMenuItem = "ペースト";
            ob.deleteToolStripMenuItem = "消去";
            ob.gotoToolStripMenuItem = "に移動";
            ob.findToolStripMenuItem = "探す";
            ob.replaceToolStripMenuItem = "交換";
            ob.selectAllToolStripMenuItem = "すべて選択";
            ob.timeDateToolStripMenuItem = "時間";

            ob.formatToolStripMenuItem = "フォーマット";
            ob.wordWToolStripMenuItem = "ワードラップ";
            ob.fontToolStripMenuItem = "フォント";

            ob.viewToolStripMenuItem = "意見";
            ob.statusBarToolStripMenuItem = "ステータスバー";

            ob.helpToolStripMenuItem = "ヘルプ";
            ob.aboutToolStripMenuItem = "約";

            ob.languageToolStripMenuItem = "言語";
            return ob;
        }
    }
    class English : IChangeLanguage
    {
        public Language_ob changeLanguage(Language_ob ob)
        {
            ob.fileToolStripMenuItem = "File";
            ob.newToolStripMenuItem = "New";
            ob.openToolStripMenuItem = "Open";
            ob.saveToolStripMenuItem = "Save";
            ob.saveAsToolStripMenuItem = "Save As";
            ob.printToolStripMenuItem = "Print";
            ob.exitToolStripMenuItem = "Exit";

            ob.editToolStripMenuItem = "Edit";
            ob.undoToolStripMenuItem = "Undo";
            ob.cutToolStripMenuItem = "Cut";
            ob.copyToolStripMenuItem = "Copy";
            ob.colorToolStripMenuItem = "Color";
            ob.pasteToolStripMenuItem = "Paste";
            ob.deleteToolStripMenuItem = "Delete";
            ob.gotoToolStripMenuItem = "Go to";
            ob.findToolStripMenuItem = "Find";
            ob.replaceToolStripMenuItem = "Replace";
            ob.selectAllToolStripMenuItem = "Select All";
            ob.timeDateToolStripMenuItem = "Time/Date";

            ob.formatToolStripMenuItem = "Format";
            ob.wordWToolStripMenuItem = "Word Wrap";
            ob.fontToolStripMenuItem = "Font";

            ob.viewToolStripMenuItem = "View";
            ob.statusBarToolStripMenuItem = "Status bar";

            ob.helpToolStripMenuItem = "Help";
            ob.aboutToolStripMenuItem = "About";

            ob.languageToolStripMenuItem = "Language";
            return ob;
        }
    }
}
