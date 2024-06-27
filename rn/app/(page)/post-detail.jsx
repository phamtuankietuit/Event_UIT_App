import { SafeAreaView } from "react-native-safe-area-context"
import {
  ScrollView,
  Text,
  TouchableOpacity,
  View,
  Image,
  Modal,
  FlatList,
} from "react-native"
import { AntDesign } from "@expo/vector-icons"
import { useSelector, useDispatch } from "react-redux"
import { setFullScreenImage, clearFullScreenImage } from "../redux/imageSlice"
import { Ionicons } from "@expo/vector-icons"
import { MaterialIcons } from "@expo/vector-icons"
import { StatusBar } from "expo-status-bar"

const avt = require("../../assets/images/Logo.png")
const images = [
  require("../../assets/images/img1.jpg"),
  require("../../assets/images/img2.jpg"),
  require("../../assets/images/img3.jpg"),
  require("../../assets/images/img4.jpg"),
  require("../../assets/images/img5.jpg"),
]

const PostDetail = () => {
  const fullScreenImage = useSelector((state) => state.image.fullScreenImage)
  const dispatch = useDispatch()

  const handleImagePress = (image) => {
    dispatch(setFullScreenImage(image))
  }

  const renderImageItem = ({ item }) => (
    <TouchableOpacity onPress={() => handleImagePress(item)}>
      <Image source={item} className='h-full w-[250]' resizeMode='cover' />
    </TouchableOpacity>
  )

  return (
    <View className='flex-1 bg-white'>
      <StatusBar></StatusBar>
      <View className='flex-1 pb-20'>
        <ScrollView showsVerticalScrollIndicator={false}>
          <View
            className='h-[50]  w-full  flex-row items-center justify-between px-2'
            style={{ borderBottomWidth: 0.5, borderColor: "#cdcdcd" }}
          >
            <View className=' flex-row items-center '>
              <TouchableOpacity>
                <AntDesign name='left' size={24} color='#6F6A61' />
              </TouchableOpacity>
            </View>
            <View>
              <TouchableOpacity className=' rounded bg-blue-600 p-2'>
                <Text style={{ color: "white" }}>CHỈNH SỬA</Text>
              </TouchableOpacity>
            </View>
          </View>
          {/* khung avt */}
          <View className='py-[6] pl-1'>
            <View className='flex-row'>
              <View className='mr-1 h-[70] w-[70] rounded-full'>
                <Image
                  source={avt}
                  className='absolute h-full w-full rounded-full'
                ></Image>
              </View>
              <View className='justify-center'>
                <Text className=' text-lg font-semibold'>Admin</Text>
                <Text className='text-xs'>22 thg 6</Text>
              </View>
            </View>
          </View>
          {/* Nội dung */}
          <View className='px-2'>
            <Text className='text-lg font-semibold'>
              Hội thảo 'Công nghệ AI trong Y học'
            </Text>
            <Text className='text-base'>
              Khám phá những ứng dụng mới nhất của trí tuệ nhân tạo trong lĩnh
              vực y tế, cùng với các chuyên gia hàng đầu.
            </Text>
            <Text className='text-base'>
              Địa điểm: Hội trường A, Trường Đại học Công nghệ Thông tin
            </Text>
            <View>
              <Text className='text-base font-semibold'>Form tham dự:</Text>
              <Text className='text-base text-blue-400 underline'>
                https://forms.gle/HkCD86Gc9UmTTZLP9
              </Text>
            </View>
            <View>
              <Text className='text-base font-semibold'>
                Thời gian bắt đầu:
              </Text>
              <Text className='text-base text-blue-400'>9:00 22/06/2024</Text>
            </View>
            <View>
              <Text className='text-base font-semibold'>
                Thời gian kết thúc:
              </Text>
              <Text className='text-base text-blue-400'>10:00 29/06/2024</Text>
            </View>
            <View>
              <Text className='text-base font-semibold'>Loại sự kiện:</Text>
              <Text className='text-base text-blue-400'>Seminar</Text>
            </View>
          </View>
          {/* View chứa ảnh */}
          <View className='h-[300] w-full flex-1 items-center px-1 py-5 '>
            <FlatList
              data={images}
              renderItem={renderImageItem}
              keyExtractor={(item, index) => index.toString()}
              horizontal
              showsHorizontalScrollIndicator={false}
            />
          </View>
          {/* số ng tham gia */}
        </ScrollView>
      </View>
      <View className='absolute bottom-0 w-full items-center bg-white py-[10]'>
        <ScrollView horizontal showsHorizontalScrollIndicator={false}>
          <View className=' ml-2 mr-1 w-[180] flex-row items-center justify-center rounded-xl bg-slate-200 py-3'>
            <Ionicons name='people' size={24} color='gray' />
            <Text className='ml-1 flex-shrink'>Số lượng tham gia:</Text>
            <Text className='flex-shrink'> 30</Text>
          </View>
          <View className='mr-1 w-[180] flex-row items-center justify-center rounded-xl bg-slate-200 py-3'>
            <Ionicons name='checkmark-done' size={24} color='gray' />
            <Text className='ml-1 flex-shrink'>Đã được công bố</Text>
          </View>
          <View className='mr-1 w-[180] flex-row items-center justify-center rounded-xl bg-slate-200 py-3'>
            <MaterialIcons name='event' size={24} color='gray' />
            <Text className='ml-1 flex-shrink'>Loại sự kiện:</Text>
            <Text> Seminar</Text>
          </View>
        </ScrollView>
      </View>
      {/* Modal xem ảnh toàn màn hình */}
      {fullScreenImage && (
        <Modal
          visible={true}
          transparent={true}
          onRequestClose={() => dispatch(clearFullScreenImage())}
        >
          <View className='h-full w-full flex-1 bg-black'>
            <TouchableOpacity onPress={() => dispatch(clearFullScreenImage())}>
              <Image
                source={fullScreenImage}
                className='h-full w-full'
                resizeMode='contain'
              />
            </TouchableOpacity>
          </View>
        </Modal>
      )}
    </View>
  )
}

export default PostDetail
