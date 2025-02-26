from PDFNetPython3 import *
import os
import easygui
import xml.dom.minidom
list_file =[]
def count_py_files_in_repos(dirname, tot_file):
    if os.path.exists(os.path.join(dirname)):
        for root, dirs, files in os.walk(dirname):
            for f in files :
                if ('.pdf' in f):
                    tot_file=tot_file+1
                    list_file.append((os.path.join(root, f)))
        for name in dirs:
            path = os.path.join(root,name)
            if os.path.isdir(path):
                count_py_files_in_repos(path, tot_file)
    return tot_file,excel_file

def sort_choose():
    '''allows user to choose folder to sort
    '''
    global download_dir
    msg = "Please select the folder to sort: "
    title = "Folder to sort..."
    download_dir = easygui.diropenbox(msg, title)
    draw_chart["state"] = "normal"
    creat_dbutton["state"] = "disabled"
    #draw_chart["state"] = "normal"
    openexcel["state"] = "disabled"
    return download_dir

PDFNet.Initialize("demo:1635245895327:78b4b4fa0300000000c243b7e837f2956c2d303d2cc20f10f50ee471cb")
doc = PDFDoc("D:\\pdf_vba\\3000410_CTD_000_GENERELL.pdf")

# Extract annotations to FDF.
# Optionally use e_both to extract both forms and annotations
doc_fields = doc.FDFExtract(PDFDoc.e_annots_only) #PDFDoc.e_forms_only

# Export annotations from FDF to XFDF.
doc_fields.SaveAsXFDF("output_xfdf_filename.xml")

# Optionally write XFDF to a string
XFDF_string = doc_fields.SaveAsXFDF()
