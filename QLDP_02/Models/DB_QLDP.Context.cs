﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLDP_02.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DB_QLDPEntities : DbContext
    {
        public DB_QLDPEntities()
            : base("name=DB_QLDPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DM_DP_DonViTinh> DM_DP_DonViTinh { get; set; }
        public virtual DbSet<DM_DP_LoaiSanPham> DM_DP_LoaiSanPham { get; set; }
        public virtual DbSet<DM_DP_LyDoCapPhat> DM_DP_LyDoCapPhat { get; set; }
        public virtual DbSet<DM_DP_NhaCungCap> DM_DP_NhaCungCap { get; set; }
        public virtual DbSet<DM_DP_TinhChatDongPhuc> DM_DP_TinhChatDongPhuc { get; set; }
        public virtual DbSet<DM_DP_TrangThaiDuyet> DM_DP_TrangThaiDuyet { get; set; }
        public virtual DbSet<NS_DP_GioiTinh> NS_DP_GioiTinh { get; set; }
        public virtual DbSet<NS_DP_PhieuDeNghi> NS_DP_PhieuDeNghi { get; set; }
        public virtual DbSet<NS_DP_PhieuDeNghi_CaNhan> NS_DP_PhieuDeNghi_CaNhan { get; set; }
        public virtual DbSet<NS_DP_PhieuDeNghi_CaNhan_ChiTiet> NS_DP_PhieuDeNghi_CaNhan_ChiTiet { get; set; }
        public virtual DbSet<NS_DP_PhieuDeNghi_ChiTiet> NS_DP_PhieuDeNghi_ChiTiet { get; set; }
        public virtual DbSet<NS_DP_PhieuNhapHang> NS_DP_PhieuNhapHang { get; set; }
        public virtual DbSet<NS_DP_PhieuNhapHang_ChiTiet> NS_DP_PhieuNhapHang_ChiTiet { get; set; }
        public virtual DbSet<NS_DP_SanPham> NS_DP_SanPham { get; set; }
        public virtual DbSet<NS_DP_SanPham_TinhChatDongPhuc> NS_DP_SanPham_TinhChatDongPhuc { get; set; }
        public virtual DbSet<NS_DP_XuatNhapKho> NS_DP_XuatNhapKho { get; set; }
        public virtual DbSet<NS_DP_XuatNhapKho_ChiTiet> NS_DP_XuatNhapKho_ChiTiet { get; set; }
        public virtual DbSet<NS_NhanSu> NS_NhanSu { get; set; }
        public virtual DbSet<DM_DP_Kho> DM_DP_Kho { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<NS_QuocTich> NS_QuocTich { get; set; }
        public virtual DbSet<DM_DP_Size> DM_DP_Size { get; set; }
        public virtual DbSet<NS_DP_LoaiPhieu> NS_DP_LoaiPhieu { get; set; }
        public virtual DbSet<NS_DP_XuatKho_ChiTiet_NhanSu> NS_DP_XuatKho_ChiTiet_NhanSu { get; set; }
    
        public virtual ObjectResult<getPhieuNhapHang_Result> getPhieuNhapHang()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getPhieuNhapHang_Result>("getPhieuNhapHang");
        }
    
        public virtual ObjectResult<getXuatNhapKho_Result> getXuatNhapKho()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getXuatNhapKho_Result>("getXuatNhapKho");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<getXuatKho_Result> getXuatKho()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getXuatKho_Result>("getXuatKho");
        }
    
        public virtual ObjectResult<getSize_Result> getSize()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getSize_Result>("getSize");
        }
    
        public virtual ObjectResult<getPhieuDeNghiCaNhan_Result> getPhieuDeNghiCaNhan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getPhieuDeNghiCaNhan_Result>("getPhieuDeNghiCaNhan");
        }
    
        public virtual int updateLyDoCapPhat(string maPhieu, Nullable<int> nguoiDeNghi, Nullable<int> idLyDoCapPhat)
        {
            var maPhieuParameter = maPhieu != null ?
                new ObjectParameter("maPhieu", maPhieu) :
                new ObjectParameter("maPhieu", typeof(string));
    
            var nguoiDeNghiParameter = nguoiDeNghi.HasValue ?
                new ObjectParameter("nguoiDeNghi", nguoiDeNghi) :
                new ObjectParameter("nguoiDeNghi", typeof(int));
    
            var idLyDoCapPhatParameter = idLyDoCapPhat.HasValue ?
                new ObjectParameter("idLyDoCapPhat", idLyDoCapPhat) :
                new ObjectParameter("idLyDoCapPhat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateLyDoCapPhat", maPhieuParameter, nguoiDeNghiParameter, idLyDoCapPhatParameter);
        }
    
        public virtual ObjectResult<getDanhSachSanPhamTheoGioiTinhNhanSu_Result> getDanhSachSanPhamTheoGioiTinhNhanSu(Nullable<int> nhanSu)
        {
            var nhanSuParameter = nhanSu.HasValue ?
                new ObjectParameter("NhanSu", nhanSu) :
                new ObjectParameter("NhanSu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getDanhSachSanPhamTheoGioiTinhNhanSu_Result>("getDanhSachSanPhamTheoGioiTinhNhanSu", nhanSuParameter);
        }
    
        public virtual ObjectResult<getSanPhamYeuCau_Result> getSanPhamYeuCau()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getSanPhamYeuCau_Result>("getSanPhamYeuCau");
        }
    
        public virtual ObjectResult<getSanPhamConLaiChuaChon_Result> getSanPhamConLaiChuaChon(string maPhieuDeNghi_CaNhan, Nullable<int> nguoiDeNghi)
        {
            var maPhieuDeNghi_CaNhanParameter = maPhieuDeNghi_CaNhan != null ?
                new ObjectParameter("MaPhieuDeNghi_CaNhan", maPhieuDeNghi_CaNhan) :
                new ObjectParameter("MaPhieuDeNghi_CaNhan", typeof(string));
    
            var nguoiDeNghiParameter = nguoiDeNghi.HasValue ?
                new ObjectParameter("NguoiDeNghi", nguoiDeNghi) :
                new ObjectParameter("NguoiDeNghi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getSanPhamConLaiChuaChon_Result>("getSanPhamConLaiChuaChon", maPhieuDeNghi_CaNhanParameter, nguoiDeNghiParameter);
        }
    
        public virtual int themSanPhamConLaiNguoiDungChuChon(Nullable<int> phieuDeNghi_CaNhan, Nullable<int> sanPham, Nullable<int> size, Nullable<int> soLuong, Nullable<int> tinhChatDongPhuc)
        {
            var phieuDeNghi_CaNhanParameter = phieuDeNghi_CaNhan.HasValue ?
                new ObjectParameter("PhieuDeNghi_CaNhan", phieuDeNghi_CaNhan) :
                new ObjectParameter("PhieuDeNghi_CaNhan", typeof(int));
    
            var sanPhamParameter = sanPham.HasValue ?
                new ObjectParameter("SanPham", sanPham) :
                new ObjectParameter("SanPham", typeof(int));
    
            var sizeParameter = size.HasValue ?
                new ObjectParameter("Size", size) :
                new ObjectParameter("Size", typeof(int));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("SoLuong", soLuong) :
                new ObjectParameter("SoLuong", typeof(int));
    
            var tinhChatDongPhucParameter = tinhChatDongPhuc.HasValue ?
                new ObjectParameter("TinhChatDongPhuc", tinhChatDongPhuc) :
                new ObjectParameter("TinhChatDongPhuc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("themSanPhamConLaiNguoiDungChuChon", phieuDeNghi_CaNhanParameter, sanPhamParameter, sizeParameter, soLuongParameter, tinhChatDongPhucParameter);
        }
    
        public virtual ObjectResult<getSizeFromSanPham_Result> getSizeFromSanPham(Nullable<int> masp)
        {
            var maspParameter = masp.HasValue ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getSizeFromSanPham_Result>("getSizeFromSanPham", maspParameter);
        }
    
        public virtual ObjectResult<getTinhChatTuSanPham_Result> getTinhChatTuSanPham(Nullable<int> sanPham)
        {
            var sanPhamParameter = sanPham.HasValue ?
                new ObjectParameter("sanPham", sanPham) :
                new ObjectParameter("sanPham", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getTinhChatTuSanPham_Result>("getTinhChatTuSanPham", sanPhamParameter);
        }
    
        public virtual ObjectResult<selectOptionGetPhieuNhap_Result> selectOptionGetPhieuNhap()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectOptionGetPhieuNhap_Result>("selectOptionGetPhieuNhap");
        }
    
        public virtual ObjectResult<getSanPhamByNhaCungCap_Result> getSanPhamByNhaCungCap(Nullable<int> nhaCungCap)
        {
            var nhaCungCapParameter = nhaCungCap.HasValue ?
                new ObjectParameter("NhaCungCap", nhaCungCap) :
                new ObjectParameter("NhaCungCap", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getSanPhamByNhaCungCap_Result>("getSanPhamByNhaCungCap", nhaCungCapParameter);
        }
    
        public virtual int getSanhSachSanPham()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("getSanhSachSanPham");
        }
    
        public virtual ObjectResult<PhieuNhap_GetSanhSachSanPham_Result> PhieuNhap_GetSanhSachSanPham()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PhieuNhap_GetSanhSachSanPham_Result>("PhieuNhap_GetSanhSachSanPham");
        }
    
        public virtual ObjectResult<getDanhSachSanPham_Result> getDanhSachSanPham()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getDanhSachSanPham_Result>("getDanhSachSanPham");
        }
    
        public virtual ObjectResult<NhapKho_GetSelectPhieuNhapHang_Result> NhapKho_GetSelectPhieuNhapHang()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhapKho_GetSelectPhieuNhapHang_Result>("NhapKho_GetSelectPhieuNhapHang");
        }
    
        public virtual ObjectResult<NhapKho_SelectPhieuNhapHang_Result> NhapKho_SelectPhieuNhapHang()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhapKho_SelectPhieuNhapHang_Result>("NhapKho_SelectPhieuNhapHang");
        }
    
        public virtual ObjectResult<NhapKho_getAllDanhSachNhapHang_Result> NhapKho_getAllDanhSachNhapHang()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhapKho_getAllDanhSachNhapHang_Result>("NhapKho_getAllDanhSachNhapHang");
        }
    
        public virtual ObjectResult<NhapKho_getSoLuongDeXoa_Result> NhapKho_getSoLuongDeXoa(Nullable<int> xuatNhapKho)
        {
            var xuatNhapKhoParameter = xuatNhapKho.HasValue ?
                new ObjectParameter("XuatNhapKho", xuatNhapKho) :
                new ObjectParameter("XuatNhapKho", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhapKho_getSoLuongDeXoa_Result>("NhapKho_getSoLuongDeXoa", xuatNhapKhoParameter);
        }
    
        public virtual ObjectResult<DPBP_HienThiSanPham_Result> DPBP_HienThiSanPham()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DPBP_HienThiSanPham_Result>("DPBP_HienThiSanPham");
        }
    
        public virtual ObjectResult<DPBP_GetAllPhieuDeNghi_Result> DPBP_GetAllPhieuDeNghi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DPBP_GetAllPhieuDeNghi_Result>("DPBP_GetAllPhieuDeNghi");
        }
    
        public virtual ObjectResult<DPBP_GetSanPhamByPhieu_Result> DPBP_GetSanPhamByPhieu(Nullable<int> phieu)
        {
            var phieuParameter = phieu.HasValue ?
                new ObjectParameter("Phieu", phieu) :
                new ObjectParameter("Phieu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DPBP_GetSanPhamByPhieu_Result>("DPBP_GetSanPhamByPhieu", phieuParameter);
        }
    
        public virtual ObjectResult<getPhieuDeNghi_Result> getPhieuDeNghi(Nullable<int> phieuDeNghi)
        {
            var phieuDeNghiParameter = phieuDeNghi.HasValue ?
                new ObjectParameter("PhieuDeNghi", phieuDeNghi) :
                new ObjectParameter("PhieuDeNghi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getPhieuDeNghi_Result>("getPhieuDeNghi", phieuDeNghiParameter);
        }
    
        public virtual ObjectResult<getAllDonMuaHang_Result> getAllDonMuaHang()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllDonMuaHang_Result>("getAllDonMuaHang");
        }
    
        public virtual ObjectResult<NhapHang_getAllDonMuaHang_Result> NhapHang_getAllDonMuaHang()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhapHang_getAllDonMuaHang_Result>("NhapHang_getAllDonMuaHang");
        }
    
        public virtual ObjectResult<NhapHang_getDonHangByMaPhieu_Result> NhapHang_getDonHangByMaPhieu(Nullable<int> phieu)
        {
            var phieuParameter = phieu.HasValue ?
                new ObjectParameter("phieu", phieu) :
                new ObjectParameter("phieu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhapHang_getDonHangByMaPhieu_Result>("NhapHang_getDonHangByMaPhieu", phieuParameter);
        }
    
        public virtual ObjectResult<NhapHang_SanPhamByMaPhieu_Result> NhapHang_SanPhamByMaPhieu(Nullable<int> phieu)
        {
            var phieuParameter = phieu.HasValue ?
                new ObjectParameter("phieu", phieu) :
                new ObjectParameter("phieu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhapHang_SanPhamByMaPhieu_Result>("NhapHang_SanPhamByMaPhieu", phieuParameter);
        }
    
        public virtual ObjectResult<NhapKho_HienThiSanPhamTheoPhieu_Result> NhapKho_HienThiSanPhamTheoPhieu(Nullable<int> xuatNhapKho)
        {
            var xuatNhapKhoParameter = xuatNhapKho.HasValue ?
                new ObjectParameter("XuatNhapKho", xuatNhapKho) :
                new ObjectParameter("XuatNhapKho", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhapKho_HienThiSanPhamTheoPhieu_Result>("NhapKho_HienThiSanPhamTheoPhieu", xuatNhapKhoParameter);
        }
    
        public virtual ObjectResult<NhapKho_ChangeSelectPhieuNhap_Result> NhapKho_ChangeSelectPhieuNhap(Nullable<int> maPhieu)
        {
            var maPhieuParameter = maPhieu.HasValue ?
                new ObjectParameter("maPhieu", maPhieu) :
                new ObjectParameter("maPhieu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhapKho_ChangeSelectPhieuNhap_Result>("NhapKho_ChangeSelectPhieuNhap", maPhieuParameter);
        }
    
        public virtual ObjectResult<CaNhan_RenderTable_Result> CaNhan_RenderTable()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CaNhan_RenderTable_Result>("CaNhan_RenderTable");
        }
    
        public virtual ObjectResult<XuatKho_getAllPhieuXuatKho_Result> XuatKho_getAllPhieuXuatKho()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<XuatKho_getAllPhieuXuatKho_Result>("XuatKho_getAllPhieuXuatKho");
        }
    
        public virtual ObjectResult<XuatKho_GetSanPhamByPhieu_Result> XuatKho_GetSanPhamByPhieu(Nullable<int> xuatnhapkho, Nullable<int> idPhieu)
        {
            var xuatnhapkhoParameter = xuatnhapkho.HasValue ?
                new ObjectParameter("xuatnhapkho", xuatnhapkho) :
                new ObjectParameter("xuatnhapkho", typeof(int));
    
            var idPhieuParameter = idPhieu.HasValue ?
                new ObjectParameter("idPhieu", idPhieu) :
                new ObjectParameter("idPhieu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<XuatKho_GetSanPhamByPhieu_Result>("XuatKho_GetSanPhamByPhieu", xuatnhapkhoParameter, idPhieuParameter);
        }
    
        public virtual ObjectResult<DPBP_GetLichSuNhanSu_Result> DPBP_GetLichSuNhanSu(Nullable<int> nhansu)
        {
            var nhansuParameter = nhansu.HasValue ?
                new ObjectParameter("nhansu", nhansu) :
                new ObjectParameter("nhansu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DPBP_GetLichSuNhanSu_Result>("DPBP_GetLichSuNhanSu", nhansuParameter);
        }
    
        public virtual ObjectResult<BaoCao_DPBP_GetLichSuNhanSu_Result> BaoCao_DPBP_GetLichSuNhanSu(Nullable<int> nhansu)
        {
            var nhansuParameter = nhansu.HasValue ?
                new ObjectParameter("nhansu", nhansu) :
                new ObjectParameter("nhansu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BaoCao_DPBP_GetLichSuNhanSu_Result>("BaoCao_DPBP_GetLichSuNhanSu", nhansuParameter);
        }
    
        public virtual ObjectResult<GetBaoCaoTonKho_Result1> GetBaoCaoTonKho(string thang, string nam, Nullable<int> nCC)
        {
            var thangParameter = thang != null ?
                new ObjectParameter("Thang", thang) :
                new ObjectParameter("Thang", typeof(string));
    
            var namParameter = nam != null ?
                new ObjectParameter("Nam", nam) :
                new ObjectParameter("Nam", typeof(string));
    
            var nCCParameter = nCC.HasValue ?
                new ObjectParameter("NCC", nCC) :
                new ObjectParameter("NCC", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBaoCaoTonKho_Result1>("GetBaoCaoTonKho", thangParameter, namParameter, nCCParameter);
        }
    
        public virtual ObjectResult<XuatKho_GetDanhSachCapPhatNhanSu_Result> XuatKho_GetDanhSachCapPhatNhanSu(Nullable<int> xuatNhapKho)
        {
            var xuatNhapKhoParameter = xuatNhapKho.HasValue ?
                new ObjectParameter("XuatNhapKho", xuatNhapKho) :
                new ObjectParameter("XuatNhapKho", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<XuatKho_GetDanhSachCapPhatNhanSu_Result>("XuatKho_GetDanhSachCapPhatNhanSu", xuatNhapKhoParameter);
        }
    
        public virtual ObjectResult<XuatKho_GetSanPham_Result> XuatKho_GetSanPham(Nullable<int> phieuDeNghi, Nullable<int> nhaCungCap)
        {
            var phieuDeNghiParameter = phieuDeNghi.HasValue ?
                new ObjectParameter("PhieuDeNghi", phieuDeNghi) :
                new ObjectParameter("PhieuDeNghi", typeof(int));
    
            var nhaCungCapParameter = nhaCungCap.HasValue ?
                new ObjectParameter("NhaCungCap", nhaCungCap) :
                new ObjectParameter("NhaCungCap", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<XuatKho_GetSanPham_Result>("XuatKho_GetSanPham", phieuDeNghiParameter, nhaCungCapParameter);
        }
    }
}
