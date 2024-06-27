// Import các thư viện cần thiết
import React, { useRef } from "react"
import { StyleSheet, View, Button } from "react-native"
import { RichEditor, RichToolbar, actions } from "react-native-pell-rich-editor"

const TextEditor = () => {
  const richText = useRef(null)

  return (
    <View
      className=' rounded-[5px] bg-white'
      style={{
        shadowColor: "#000000",
        shadowOffset: {
          width: 0,
          height: 3,
        },
        shadowOpacity: 0.17,
        shadowRadius: 3.05,
        elevation: 4,
      }}
    >
      <View
        style={{
          backgroundColor: "#fff",
          borderTopLeftRadius: 5,
          borderTopRightRadius: 5,
        }}
      >
        <RichEditor
          ref={richText}
          placeholder='Nhập mô tả...'
          // Không thêm tùy chọn thêm ảnh
          editorInitializedCallback={() => {
            richText.current.registerToolbar((items) => {
              console.log("Toolbar items:", items)
            })
          }}
          editorStyle={styles.editorStyle} // Thêm styles cho nội dung của RichEditor
        />
      </View>
      <RichToolbar
        editor={richText}
        actions={[
          actions.setBold,
          actions.setItalic,
          actions.setUnderline,
          actions.heading1,
          actions.heading2,
          actions.insertBulletsList,
          actions.insertOrderedList,
        ]}
        iconTint='#000'
        selectedIconTint='#2095F2'
        disabledIconTint='#bfbfbf'
        style={styles.richToolbar}
      />
    </View>
  )
}

const styles = StyleSheet.create({
  richToolbar: {
    flex: 1,
    borderTopWidth: 1,
    borderColor: "#ddd",
    backgroundColor: "#fff", // Nền trắng cho toolbar
    height: 40,
    borderBottomLeftRadius: 5, // Thêm borderRadius cho toolbar
    borderBottomRightRadius: 5, // Thêm borderRadius cho toolbar
  },
  editorStyle: {
    backgroundColor: "transparent", // Nền trắng cho nội dung editor
    color: "#000", // Màu chữ
    placeholderColor: "#888", // Màu placeholder
    contentCSSText: "font-size: 16px; padding: 10px;", // CSS cho nội dung
  },
})

export default TextEditor
