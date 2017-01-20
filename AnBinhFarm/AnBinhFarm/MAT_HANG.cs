using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnBinhFarm
{
    public class MAT_HANG
    {
        #region "Biến thành viên"
        private int mMs;
        private string mTen_sp;
        private float mDon_gia;
        private int mSo_luong;
       // private float mThanh_tien;
        private string mImage;
        private string maTen;
        private bool mIsDeal;
        
        #endregion
        #region "Thuộc tính"
        public int Ms
        {
            get { return mMs; }
            set { mMs = value; }
        }
        public string Ten_sp
        {
            get { return mTen_sp; }
            set { mTen_sp = value; }
        }
        public float Don_gia
        {
            get { return mDon_gia; }
            set { mDon_gia = value; }
        }
        public int So_luong
        {
            get { return mSo_luong; }
            set { mSo_luong = value; }
        }

        public float Thanh_tien
        {
            get { return mSo_luong * mDon_gia; }
        }
        
        public string Image
        {
            get
            {
                return mImage;
            }
            set
            {
                if (mImage == value)
                    return;
                mImage = value;
            }
        }
        public string MaTen
        {
            get { return maTen; }
            set { maTen = value; }
        }
        public bool IsDeal
        {
            get
            {
                return mIsDeal;
            }
            set
            {
                if (mIsDeal == value)
                    return;
                mIsDeal = value;
            }
        }
        #endregion
        #region "Khoi tao"
        public MAT_HANG()
        { }
        public MAT_HANG(int pMs, string pmaTen, string pTen, string pImage,bool pisDeal,float pDgia, int pSluong)
        {
            mMs = pMs;
            maTen = pmaTen;
            mTen_sp = pTen;
            mDon_gia = pDgia;
            mSo_luong = pSluong;
            mImage = pImage;
            mIsDeal = pisDeal;
        }
        #endregion
    }
   
}