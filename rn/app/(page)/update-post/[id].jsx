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
import { useLocalSearchParams } from "expo-router"

const styles = StyleSheet.create({
  header: {
    borderBottomWidth: 0.7,
  },
  imageContainer: {
    marginRight: 10,
    position: "relative",
  },
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
const UpdatePost = () => {
  const { id } = useLocalSearchParams()
  const [selectedImages, setSelectedImages] = useState([])
  const [postContent, setPostContent] = useState("")

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
      setSelectedImages([...selectedImages, ...selectedAssets])
    }
  }

  const isCreateButtonEnabled =
    selectedImages.length > 0 && postContent.length > 0

  const deleteImage = (uri) => {
    setSelectedImages(selectedImages.filter((image) => image !== uri))
  }
  return (
    <SafeAreaView className=' flex-1 bg-white '>
      <View className='flex-1'>
        <View
          className='h-[46] w-full  flex-row items-center justify-between px-2'
          style={styles.header}
        >
          <View className=' flex-row items-center '>
            <TouchableOpacity>
              <AntDesign name='left' size={15} color='#6F6A61' />
            </TouchableOpacity>
            <Text
              className=' ml-2 font-semibold'
              style={{ fontSize: 15, color: "#6F6A61" }}
            >
              Sửa bài đăng
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
                THAY ĐỔI
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
            onChangeText={setPostContent}
          ></TextInput>
        </ScrollView>
        <View className='absolute bottom-0'>
          <FlatList
            data={selectedImages}
            horizontal
            keyExtractor={(item) => item}
            contentContainerStyle={styles.flatListContainer}
            renderItem={({ item }) => (
              <View style={styles.imageContainer}>
                <Image source={{ uri: item }} style={styles.image} />
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

export default UpdatePost
