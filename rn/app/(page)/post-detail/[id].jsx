import {
  ScrollView,
  Text,
  TouchableOpacity,
  View,
  Image,
  Modal,
  FlatList,
  Alert,
  ToastAndroid,
} from "react-native"
import { useSelector, useDispatch } from "react-redux"
import {
  setFullScreenImage,
  clearFullScreenImage,
} from "../../redux/imageSlice"
import { Ionicons, MaterialIcons, AntDesign } from "@expo/vector-icons"
import { StatusBar } from "expo-status-bar"
import { Linking, ActivityIndicator } from "react-native"
import { useLocalSearchParams, useRouter } from "expo-router"
import { useEffect, useState } from "react"
import * as eventServices from "../../apiServices/eventServices"
import * as asyncStorage from "../../store/asyncStorage"
import dayjs from "dayjs"
import { Link } from "expo-router"

const avt = require("../../../assets/images/Logo.png")

import MyHeader from "../../components/MyHeader"

const showToastWithGravity = (msg) => {
  ToastAndroid.showWithGravity(
    msg || "hello",
    ToastAndroid.SHORT,
    ToastAndroid.CENTER
  )
}

const PostDetail = () => {
  const router = useRouter()
  const { id } = useLocalSearchParams()
  const [data, setData] = useState(null)
  const [isUnit, setIsUnit] = useState(false)

  const [images, setImages] = useState([])

  const fullScreenImage = useSelector((state) => state.image.fullScreenImage)

  const [buttonLoading, setButtonLoading] = useState(false)
  const [isRegister, setIsRegister] = useState(false)

  const dispatch = useDispatch()

  const handleImagePress = (image) => {
    dispatch(setFullScreenImage(image))
  }

  const renderImageItem = ({ item }) => (
    <TouchableOpacity onPress={() => handleImagePress(item)}>
      <Image
        source={{ uri: item }}
        className='mr-2 h-full w-[250] rounded-xl'
        resizeMode='cover'
      />
    </TouchableOpacity>
  )

  const getDetailEvent = async () => {
    const response = await eventServices.getDetailEvent(id).catch((error) => {
      showToastWithGravity("Có lỗi xảy ra!")
      console.log(error.response.data)
    })

    if (response) {
      console.log(response)
      setData(response)
      setImages(response.images.map((item) => item.imageUrl))
      setIsRegister(response.isThisStudentRegistered)

      console.log(response.isThisStudentRegistered)
    }
  }

  const checkUnit = async () => {
    const role = await asyncStorage.getRole()
    if (role === "UnitAdmin") {
      setIsUnit(true)
    }
  }

  const handleRegister = async () => {
    setButtonLoading(true)
    const studentId = await asyncStorage.getIdAsync()

    const response = await eventServices
      .registerEvent(id, { EventId: id, StudentId: studentId })
      .catch((error) => {
        if (error.response.status === 409) {
          showToastWithGravity("Sự kiện đã kết thúc")
        }
        console.log("registerEvent", error)
        setButtonLoading(false)
      })

    if (response) {
      console.log(response)
      setButtonLoading(false)
      setIsRegister(true)
    }
  }

  const confirmRegister = () =>
    Alert.alert(
      "Xác nhận đăng ký",
      "Bạn có chắc chắn đăng ký sự kiện này? Bạn sẽ không thể hủy đăng ký sau đó.",
      [
        {
          text: "Hủy",
          style: "cancel",
        },
        { text: "OK", onPress: () => handleRegister() },
      ]
    )

  useEffect(() => {
    getDetailEvent()
    checkUnit()
  }, [])

  return (
    <View className='flex-1 bg-white'>
      <MyHeader title={"Chi tiết sự kiện"} />

      <StatusBar></StatusBar>
      {data === null ? (
        <ActivityIndicator size={"large"} color={"#2563eb"} />
      ) : (
        <View className='flex-1'>
          <View className='flex-1 pb-20'>
            <ScrollView showsVerticalScrollIndicator={false}>
              <View className='p-3'>
                <View className='flex-row items-start'>
                  <View className='h-10 w-10 rounded-full border-[1px] border-gray-300'>
                    <Image
                      source={{ uri: data.universityUnit.avatarUrl }}
                      className='absolute h-full w-full rounded-full'
                    ></Image>
                  </View>
                  <View className='ml-2 justify-center'>
                    <Text
                      className='w-[300px] text-sm font-bold'
                      numberOfLines={2}
                      ellipsizeMode='tail'
                    >
                      {data.universityUnit.name}
                    </Text>
                    <Text className='mt-1 text-xs'>
                      {dayjs(data.publishedDate).format("HH:mm - DD/MM/YYYY")}
                    </Text>
                  </View>
                </View>
              </View>
              {/* Nội dung */}
              <View className='px-2'>
                <Text className='text-lg font-bold leading-[25px]'>
                  {data.title}
                </Text>
                <Text className='mt-2 text-[15px] leading-[20px]'>
                  {data.description}
                </Text>
                <View className='mb-2 mt-5'>
                  <Text className='text-[15px] font-semibold'>Địa điểm:</Text>
                  <Text className='text-[15px]'>{data.location}</Text>
                </View>
                <View className='mb-2'>
                  <Text className='text-[15px] font-semibold'>
                    Form tham dự:
                  </Text>
                  <TouchableOpacity
                    onPress={() => {
                      Linking.openURL(data.formUrl)
                    }}
                  >
                    <Text className='text-[15px] text-blue-500 underline'>
                      {data.formUrl}
                    </Text>
                  </TouchableOpacity>
                </View>
                <View className='mb-2'>
                  <Text className='text-[15px] font-semibold'>
                    Thời gian bắt đầu:
                  </Text>
                  <Text className='text-[15px] '>
                    {dayjs(data.startDate).format("HH:mm - DD/MM/YYYY")}
                  </Text>
                </View>
                <View className='mb-2'>
                  <Text className='text-[15px] font-semibold'>
                    Thời gian kết thúc:
                  </Text>
                  <Text className='text-[15px]'>
                    {dayjs(data.endDate).format("HH:mm - DD/MM/YYYY")}
                  </Text>
                </View>
                <View className='mb-2'>
                  <Text className='text-[15px] font-semibold'>
                    Loại sự kiện:
                  </Text>
                  <Text className='text-[15px] '>Seminar</Text>
                </View>
                <View>
                  <Text className='text-[15px] font-semibold'>
                    Tham dự tối đa:
                  </Text>
                  <Text className='text-[15px] '>{data.maxAttendees}</Text>
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

              <View className='mx-2 mb-5 w-full flex-row'>
                {isUnit ? (
                  <Link
                    className='rounded bg-blue-500 px-5 py-2'
                    href={{
                      pathname: "(page)/update-post/[id]",
                      params: {
                        id: data.id,
                      },
                    }}
                  >
                    <Text className='font-medium text-white'>Chỉnh sửa</Text>
                  </Link>
                ) : (
                  <TouchableOpacity
                    className={`${isRegister ? "bg-slate-500" : "bg-blue-500"} rounded px-5 py-2`}
                    onPress={confirmRegister}
                    disabled={isRegister}
                  >
                    {buttonLoading ? (
                      <ActivityIndicator size='small' color='#ffffff' />
                    ) : (
                      <Text className='font-medium text-white'>
                        {isRegister ? "Đã đăng ký" : "Đăng ký"}
                      </Text>
                    )}
                  </TouchableOpacity>
                )}
              </View>
            </ScrollView>
          </View>

          <View className='absolute bottom-0 w-full items-center bg-white pb-5 shadow shadow-black'>
            <ScrollView horizontal showsHorizontalScrollIndicator={false}>
              <View className=' ml-2 mr-1 w-[180] flex-row items-center justify-center rounded-xl bg-slate-200 py-3'>
                <Ionicons name='people' size={24} color='gray' />
                <Text className='ml-1 flex-shrink'>Số lượng tham gia: </Text>
                <Text className='flex-shrink'>{data.totalRegistration}</Text>
              </View>
              <View className='mr-1 w-[180] flex-row items-center justify-center rounded-xl bg-slate-200 py-3'>
                <Ionicons name='checkmark-done' size={24} color='gray' />
                <Text className='ml-1 flex-shrink'>
                  {data.isPublished ? "Đã công khai" : "Chưa công khai"}
                </Text>
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
                <TouchableOpacity
                  onPress={() => dispatch(clearFullScreenImage())}
                >
                  <Image
                    source={{ uri: fullScreenImage }}
                    className='h-full w-full'
                    resizeMode='contain'
                  />
                </TouchableOpacity>
              </View>
            </Modal>
          )}
        </View>
      )}
    </View>
  )
}

export default PostDetail
