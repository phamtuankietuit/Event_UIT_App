import {
  View,
  Text,
  ScrollView,
  StyleSheet,
  TouchableOpacity,
  FlatList,
  Image,
  TextInput,
} from "react-native"
import { SafeAreaView } from "react-native-safe-area-context"
import { AntDesign } from "@expo/vector-icons"
import { Ionicons } from "@expo/vector-icons"
import { useState } from "react"
import * as ImagePicker from "expo-image-picker"
import { useSelector, useDispatch } from "react-redux"
import { addImages, removeImage, setPostContent } from "../../redux/postSlice"

const styles = StyleSheet.create({
  image: {
    width: 60,
    height: 60,
    borderRadius: 5,
  },
  deleteButton: {
    position: "absolute",
    top: -5,
    right: -5,
    backgroundColor: "rgba(0, 0, 0, 0.6)",
    borderRadius: 10,
    padding: 2,
  },
  flatListContainer: {
    padding: 10,
    flexDirection: "row",
  },
})
const AddPost = () => {
  const dispatch = useDispatch()
  const selectedImages = useSelector((state) => state.post.selectedImages)
  const postContent = useSelector((state) => state.post.postContent)

  const pickImage = async () => {
    if (selectedImages.length >= 5) return
    let result = await ImagePicker.launchImageLibraryAsync({
      mediaTypes: ImagePicker.MediaTypeOptions.Images,
      allowsMultipleSelection: true,
      selectionLimit: 5 - selectedImages.length,
      quality: 1,
    })

    if (!result.canceled) {
      const selectedAssets = result.assets.map((asset) => asset.uri)
      dispatch(addImages(selectedAssets))
    }
  }

  const isCreateButtonEnabled =
    selectedImages.length > 0 && postContent.length > 0

  const deleteImage = (uri) => {
    dispatch(removeImage(uri))
  }
  return (
    <SafeAreaView className=' flex-1 bg-white '>
      <View className='flex-1'>
        <View
          className='h-[46] w-full  flex-row items-center justify-between px-2'
          style={{ borderBottomWidth: 0.7 }}
        >
          <View className=' flex-row items-center '>
            <TouchableOpacity>
              <AntDesign name='left' size={15} color='#6F6A61' />
            </TouchableOpacity>
            <Text
              className=' ml-2 font-semibold'
              style={{ fontSize: 15, color: "#6F6A61" }}
            >
              Tạo bài đăng
            </Text>
          </View>
          <View>
            <TouchableOpacity
              className={`rounded p-2 ${isCreateButtonEnabled ? "bg-blue-600" : "bg-gray-400"}`}
              disabled={!isCreateButtonEnabled}
            >
              <Text
                style={{ color: isCreateButtonEnabled ? "white" : "black" }}
              >
                TẠO MỚI
              </Text>
            </TouchableOpacity>
          </View>
        </View>
        {/* Nội dung bài đăng */}
        <ScrollView>
          <TextInput
            placeholder='Nhập nội dung bài đăng...'
            className='pl-3 pt-2 text-base'
            multiline
            onChangeText={(text) => dispatch(setPostContent(text))}
          ></TextInput>
        </ScrollView>
        <View className='absolute bottom-0'>
          <FlatList
            data={selectedImages}
            horizontal
            keyExtractor={(item) => item}
            contentContainerStyle={styles.flatListContainer}
            renderItem={({ item }) => (
              <View className='relative mr-2'>
                <Image
                  source={{ uri: item }}
                  className='h-[60] w-[60] rounded-lg'
                />
                <TouchableOpacity
                  style={styles.deleteButton}
                  onPress={() => deleteImage(item)}
                >
                  <AntDesign name='close' size={15} color='white' />
                </TouchableOpacity>
              </View>
            )}
          />
        </View>
        <View className='absolute bottom-3 right-2'>
          <TouchableOpacity
            onPress={pickImage}
            className='h-[55] w-[55] items-center justify-center rounded-full bg-blue-600'
          >
            <Ionicons name='image' size={30} color='white' />
          </TouchableOpacity>
        </View>
      </View>
    </SafeAreaView>
  )
}

export default AddPost
