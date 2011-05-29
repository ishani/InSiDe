// ImageListView - A listview control for image files
// Copyright (C) 2009 Ozgur Ozcitak
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Ozgur Ozcitak (ozcitak@yahoo.com)
//
// Theme support coded by Robby

using System.ComponentModel;
using System.Drawing;

namespace Manina.Windows.Forms
{
    /// <summary>
    /// Represents the color palette of the image list view.
    /// </summary>
    public class ImageListViewColor
    {
        #region Member Variables

        Color mControlBackColor;

        Color mBackColor;
        Color mBorderColor;
        Color mUnFocusedColor1;
        Color mUnFocusedColor2;
        Color mUnFocusedBorderColor;
        Color mForeColor;
        Color mHoverColor1;
        Color mHoverColor2;
        Color mHoverBorderColor;
        Color mInsertionCaretColor;
        Color mSelectedColor1;
        Color mSelectedColor2;
        Color mSelectedBorderColor;

        // thumbnail & pane
        Color mImageInnerBorderColor;
        Color mImageOuterBorderColor;

        // details view
        Color mCellForeColor;
        Color mColumnHeaderBackColor1;
        Color mColumnHeaderBackColor2;
        Color mColumnHeaderForeColor;
        Color mColumnHeaderHoverColor1;
        Color mColumnHeaderHoverColor2;
        Color mColumnSelectColor;
        Color mColumnSeparatorColor;

        // pane
        Color mPaneBackColor;
        Color mPaneSeparatorColor;
        Color mPaneLabelColor;

        // selection rectangle
        Color mSelectionRectangleColor1;
        Color mSelectionRectangleColor2;
        Color mSelectionRectangleBorderColor;

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the background color of the ImageListView control.
        /// </summary>
        [Category("Appearance"), Description("Gets or sets the background color of the ImageListView control.")]
        public Color ControlBackColor
        {
            get { return mControlBackColor; }
            set { mControlBackColor = value; }
        }
        /// <summary>
        /// Gets or sets the background color of the ImageListViewItem.
        /// </summary>
        [Category("Appearance"), Description("Gets or sets the background color of the ImageListViewItem.")]
        public Color BackColor
        {
            get { return mBackColor; }
            set { mBackColor = value; }
        }
        /// <summary>
        /// Gets or sets the border color of the ImageListViewItem.
        /// </summary>
        [Category("Appearance"), Description("Gets or sets the border color of the ImageListViewItem.")]
        public Color BorderColor
        {
            get { return mBorderColor; }
            set { mBorderColor = value; }
        }
        /// <summary>
        /// Gets or sets the foreground color of the ImageListViewItem.
        /// </summary>
        [Category("Appearance"), Description("Gets or sets the foreground color of the ImageListViewItem.")]
        public Color ForeColor
        {
            get { return mForeColor; }
            set { mForeColor = value; }
        }
        /// <summary>
        /// Gets or sets the background gradient color1 of the ImageListViewItem if the control is not focused.
        /// </summary>
        [Category("Appearance"), Description("Gets or sets the background gradient color1 of the ImageListViewItem if the control is not focused.")]
        public Color UnFocusedColor1
        {
            get { return mUnFocusedColor1; }
            set { mUnFocusedColor1 = value; }
        }
        /// <summary>
        /// Gets or sets the background gradient color2 of the ImageListViewItem if the control is not focused.
        /// </summary>
        [Category("Appearance"), Description("Gets or sets the background gradient color2 of the ImageListViewItem if the control is not focused.")]
        public Color UnFocusedColor2
        {
            get { return mUnFocusedColor2; }
            set { mUnFocusedColor1 = value; }
        }
        /// <summary>
        /// Gets or sets the border color of the ImageListViewItem if the control is not focused.
        /// </summary>
        [Category("Appearance"), Description("Gets or sets the border color of the ImageListViewItem if the control is not focused.")]
        public Color UnFocusedBorderColor
        {
            get { return mUnFocusedBorderColor; }
            set { mUnFocusedBorderColor = value; }
        }
        /// <summary>
        /// Gets or sets the background gradient color1 if the ImageListViewItem is hovered.
        /// </summary>
        [Category("Appearance"), Description("Gets or sets the background gradient color1 if the ImageListViewItem is hovered.")]
        public Color HoverColor1
        {
            get { return mHoverColor1; }
            set { mHoverColor1 = value; }
        }
        /// <summary>
        /// Gets or sets the background gradient color2 if the ImageListViewItem is hovered.
        /// </summary>
        [Category("Appearance"), Description("Gets or sets the background gradient color2 if the ImageListViewItem is hovered.")]
        public Color HoverColor2
        {
            get { return mHoverColor2; }
            set { mHoverColor2 = value; }
        }
        /// <summary>
        /// Gets or sets the border color of the ImageListViewItem if the item is hovered.
        /// </summary>
        [Category("Appearance"), Description("Gets or sets the border color of the ImageListViewItem if the item is hovered.")]
        public Color HoverBorderColor
        {
            get { return mHoverBorderColor; }
            set { mHoverBorderColor = value; }
        }
        /// <summary>
        /// Gets or sets the color of the insertion caret.
        /// </summary>
        [Category("Appearance"), Description("Gets or sets the color of the insertion caret.")]
        public Color InsertionCaretColor
        {
            get { return mInsertionCaretColor; }
            set { mInsertionCaretColor = value; }
        }
        /// <summary>
        /// Gets or sets the background gradient color1 if the ImageListViewItem is selected.
        /// </summary>
        [Category("Appearance"), Description("Gets or sets the background gradient color1 if the ImageListViewItem is selected.")]
        public Color SelectedColor1
        {
            get { return mSelectedColor1; }
            set { mSelectedColor1 = value; }
        }
        /// <summary>
        /// Gets or sets the background gradient color2 if the ImageListViewItem is selected.
        /// </summary>
        [Category("Appearance"), Description("Gets or sets the background gradient color2 if the ImageListViewItem is selected.")]
        public Color SelectedColor2
        {
            get { return mSelectedColor2; }
            set { mSelectedColor2 = value; }
        }
        /// <summary>
        /// Gets or sets the border color of the ImageListViewItem if the item is selected.
        /// </summary>
        [Category("Appearance"), Description("Gets or sets the border color of the ImageListViewItem if the item is selected.")]
        public Color SelectedBorderColor
        {
            get { return mSelectedBorderColor; }
            set { mSelectedBorderColor = value; }
        }
        /// <summary>
        /// Gets or sets the background gradient color1 of the column header.
        /// </summary>
        [Category("Appearance Details View"), Description("Gets or sets the cells background color1 of the column header.")]
        public Color ColumnHeaderBackColor1
        {
            get { return mColumnHeaderBackColor1; }
            set { mColumnHeaderBackColor1 = value; }
        }
        /// <summary>
        /// Gets or sets the background gradient color2 of the column header.
        /// </summary>
        [Category("Appearance Details View"), Description("Gets or sets the cells background color2 of the column header.")]
        public Color ColumnHeaderBackColor2
        {
            get { return mColumnHeaderBackColor2; }
            set { mColumnHeaderBackColor2 = value; }
        }
        /// <summary>
        /// Gets or sets the background hover gradient color1 of the column header.
        /// </summary>
        [Category("Appearance Details View"), Description("Gets or sets the background hover color1 of the column header.")]
        public Color ColumnHeaderHoverColor1
        {
            get { return mColumnHeaderHoverColor1; }
            set { mColumnHeaderHoverColor1 = value; }
        }
        /// <summary>
        /// Gets or sets the background hover gradient color2 of the column header.
        /// </summary>
        [Category("Appearance Details View"), Description("Gets or sets the background hover color2 of the column header.")]
        public Color ColumnHeaderHoverColor2
        {
            get { return mColumnHeaderHoverColor2; }
            set { mColumnHeaderHoverColor2 = value; }
        }
        /// <summary>
        /// Gets or sets the cells foreground color of the coumn header text.
        /// </summary>
        [Category("Appearance Details View"), Description("Gets or sets the cells foreground color of the coumn header text.")]
        public Color ColumnHeaderForeColor
        {
            get { return mColumnHeaderForeColor; }
            set { mColumnHeaderForeColor = value; }
        }
        /// <summary>
        /// Gets or sets the cells background color if column is selected in Details View.
        /// </summary>
        [Category("Appearance Details View"), Description("Gets or sets the cells background color if column is selected in Details View.")]
        public Color ColumnSelectColor
        {
            get { return mColumnSelectColor; }
            set { mColumnSelectColor = value; }
        }
        /// <summary>
        /// Gets or sets the foreground color of the cell text in Details View.
        /// </summary>
        [Category("Appearance Details View"), Description("Gets or sets the foreground color of the cell text in Details View.")]
        public Color CellForeColor
        {
            get { return mCellForeColor; }
            set { mCellForeColor = value; }
        }
        /// <summary>
        /// Gets or sets the color of the separator in Details View.
        /// </summary>
        [Category("Appearance Details View"), Description("Gets or sets the color of the separator in Details View.")]
        public Color ColumnSeparatorColor
        {
            get { return mColumnSeparatorColor; }
            set { mColumnSeparatorColor = value; }
        }
        /// <summary>
        /// Gets or sets the background color of the image pane.
        /// </summary>
        [Category("Appearance Pane View"), Description("Gets or sets the background color of the image pane.")]
        public Color PaneBackColor
        {
            get { return mPaneBackColor; }
            set { mPaneBackColor = value; }
        }
        /// <summary>
        /// Gets or sets the separator line color between image pane and thumbnail view.
        /// </summary>
        [Category("Appearance Pane View"), Description("Gets or sets the separator line color between image pane and thumbnail view.")]
        public Color PaneSeparatorColor
        {
            get { return mPaneSeparatorColor; }
            set { mPaneSeparatorColor = value; }
        }
        /// <summary>
        /// Gets or sets the color of labels in pane view.
        /// </summary>
        [Category("Appearance Pane View"), Description("Gets or sets the color of labels in pane view.")]
        public Color PaneLabelColor
        {
            get { return mPaneLabelColor; }
            set { mPaneLabelColor = value; }
        }
        /// <summary>
        /// Gets or sets the image inner border color for thumbnails and pane.
        /// </summary>
        [Category("Appearance Image"), Description("Gets or sets the image inner border color for thumbnails and pane.")]
        public Color ImageInnerBorderColor
        {
            get { return mImageInnerBorderColor; }
            set { mImageInnerBorderColor = value; }
        }
        /// <summary>
        /// Gets or sets the image outer border color for thumbnails and pane.
        /// </summary>
        [Category("Appearance Image"), Description("Gets or sets the image outer border color for thumbnails and pane.")]
        public Color ImageOuterBorderColor
        {
            get { return mImageOuterBorderColor; }
            set { mImageOuterBorderColor = value; }
        }
        /// <summary>
        /// Gets or sets the background color1 of the selection rectangle.
        /// </summary>
        [Category("Appearance"), Description("Gets or sets the background color1 of the selection rectangle.")]
        public Color SelectionRectangleColor1
        {
            get { return mSelectionRectangleColor1; }
            set { mSelectionRectangleColor1 = value; }
        }
        /// <summary>
        /// Gets or sets the background color2 of the selection rectangle.
        /// </summary>
        [Category("Appearance"), Description("Gets or sets the background color2 of the selection rectangle.")]
        public Color SelectionRectangleColor2
        {
            get { return mSelectionRectangleColor2; }
            set { mSelectionRectangleColor2 = value; }
        }
        /// <summary>
        /// Gets or sets the color of the selection rectangle border.
        /// </summary>
        [Category("Appearance"), Description("Gets or sets the color of the selection rectangle border.")]
        public Color SelectionRectangleBorderColor
        {
            get { return mSelectionRectangleBorderColor; }
            set { mSelectionRectangleBorderColor = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the ImageListViewColor class.
        /// </summary>
        public ImageListViewColor()
        {
            // control
            mControlBackColor = SystemColors.Window;

            // item
            mBackColor = SystemColors.Window;
            mForeColor = SystemColors.ControlText;

            mBorderColor = Color.FromArgb(64, SystemColors.GrayText);

            mUnFocusedColor1 = Color.FromArgb(16, SystemColors.GrayText);
            mUnFocusedColor2 = Color.FromArgb(64, SystemColors.GrayText);
            mUnFocusedBorderColor = Color.FromArgb(128, SystemColors.GrayText);

            mHoverColor1 = Color.FromArgb(8, SystemColors.Highlight);
            mHoverColor2 = Color.FromArgb(64, SystemColors.Highlight);
            mHoverBorderColor = Color.FromArgb(64, SystemColors.Highlight);

            mSelectedColor1 = Color.FromArgb(16, SystemColors.Highlight);
            mSelectedColor2 = Color.FromArgb(128, SystemColors.Highlight);
            mSelectedBorderColor = Color.FromArgb(128, SystemColors.Highlight);

            mInsertionCaretColor = SystemColors.Highlight;

            // thumbnails & pane
            mImageInnerBorderColor = Color.FromArgb(128, Color.White);
            mImageOuterBorderColor = Color.FromArgb(128, Color.Gray);

            // details view
            mColumnHeaderBackColor1 = Color.FromArgb(32, SystemColors.Control);
            mColumnHeaderBackColor2 = Color.FromArgb(196, SystemColors.Control);
            mColumnHeaderHoverColor1 = Color.FromArgb(16, SystemColors.Highlight);
            mColumnHeaderHoverColor2 = Color.FromArgb(64, SystemColors.Highlight);
            mColumnHeaderForeColor = SystemColors.WindowText;
            mColumnSelectColor = Color.FromArgb(16, SystemColors.GrayText);
            mColumnSeparatorColor = Color.FromArgb(32, SystemColors.GrayText);
            mCellForeColor = SystemColors.ControlText;

            // image pane
            mPaneBackColor = Color.FromArgb(16, SystemColors.GrayText);
            mPaneSeparatorColor = Color.FromArgb(128, SystemColors.GrayText);
            mPaneLabelColor = SystemColors.GrayText;

            // selection rectangle
            mSelectionRectangleColor1 = Color.FromArgb(128, SystemColors.Highlight);
            mSelectionRectangleColor2 = Color.FromArgb(128, SystemColors.Highlight);
            mSelectionRectangleBorderColor = SystemColors.Highlight;
        }
        #endregion

        #region Static Members
        /// <summary>
        /// Represents the default color theme.
        /// </summary>
        public static ImageListViewColor Default = new ImageListViewColor();
        /// <summary>
        /// Represents the noir color theme.
        /// </summary>
        public static ImageListViewColor Noir = ImageListViewColor.GetNoirTheme();

        /// <summary>
        /// Sets the controls color palette to noir colors.
        /// </summary>
        private static ImageListViewColor GetNoirTheme()
        {
            ImageListViewColor c = new ImageListViewColor();

            // control
            c.ControlBackColor = Color.Black;

            // item
            c.BackColor = Color.FromArgb(0x31, 0x31, 0x31);
            c.ForeColor = Color.LightGray;

            c.BorderColor = Color.DarkGray;

            c.UnFocusedColor1 = Color.FromArgb(16, SystemColors.GrayText);
            c.UnFocusedColor2 = Color.FromArgb(64, SystemColors.GrayText);
            c.UnFocusedBorderColor = Color.FromArgb(128, SystemColors.GrayText);

            c.HoverColor1 = Color.FromArgb(64, Color.White);
            c.HoverColor2 = Color.FromArgb(16, Color.White);
            c.HoverBorderColor = Color.FromArgb(64, SystemColors.Highlight);

            c.SelectedColor1 = Color.FromArgb(64, 96, 160);
            c.SelectedColor2 = Color.FromArgb(64, 64, 96, 160);
            c.SelectedBorderColor = Color.FromArgb(128, SystemColors.Highlight);

            c.InsertionCaretColor = Color.FromArgb(96, 144, 240);

            // thumbnails & pane
            c.ImageInnerBorderColor = Color.FromArgb(128, Color.White);
            c.ImageOuterBorderColor = Color.FromArgb(128, Color.Gray);

            // details view
            c.CellForeColor = Color.WhiteSmoke;
            c.ColumnHeaderBackColor1 = Color.FromArgb(32, 128, 128, 128);
            c.ColumnHeaderBackColor2 = Color.FromArgb(196, 128, 128, 128);
            c.ColumnHeaderHoverColor1 = Color.FromArgb(64, 96, 144, 240);
            c.ColumnHeaderHoverColor2 = Color.FromArgb(196, 96, 144, 240);
            c.ColumnHeaderForeColor = Color.White;
            c.ColumnSelectColor = Color.FromArgb(96, 128, 128, 128);
            c.ColumnSeparatorColor = Color.Gold;

            // image pane
            c.PaneBackColor = Color.FromArgb(0x31, 0x31, 0x31);
            c.PaneSeparatorColor = Color.Gold;
            c.PaneLabelColor = SystemColors.GrayText;

            // selection rectangke
            c.SelectionRectangleColor1 = Color.FromArgb(160, 96, 144, 240);
            c.SelectionRectangleColor2 = Color.FromArgb(32, 96, 144, 240);
            c.SelectionRectangleBorderColor = Color.FromArgb(64, 96, 144, 240);

            return c;
        }
        #endregion
    }
}
