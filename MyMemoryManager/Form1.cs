namespace MyMemoryManager {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            Inventory.AllowDrop = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void panelItems_Paint(object sender, PaintEventArgs e) {

        }

        private bool isDragging = false;
        private Point offSet;
        private void DragStart(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                isDragging = true;
                offSet = e.Location;
            }
        }

        private void DragEnd(object sender, MouseEventArgs e) {
            isDragging = false;

            Label item = (Label)sender;

            Rectangle InventoryArea = Inventory.RectangleToScreen(
                Inventory.ClientRectangle
             );

            Rectangle ItemsArea = item.RectangleToScreen(
                item.ClientRectangle
             );

            if (InventoryArea.IntersectsWith(ItemsArea)) {
                MessageBox.Show("인벤토리 안에 아이템이 들어감.");
            }
        }

        private void Dragging(object sender, MouseEventArgs e) {
            if (isDragging) {
                Label item = (Label)sender;
                item.Left = e.X + item.Left - offSet.X;
                item.Top = e.Y + item.Top - offSet.Y;
            }

        }

        private void Inventory_Paint(object sender, PaintEventArgs e) {
        }

        private void label2_Click(object sender, EventArgs e) {

        }
    }
} 
